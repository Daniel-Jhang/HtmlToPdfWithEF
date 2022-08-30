﻿using Dapper;
using HtmlToPdfWithEF.DataAccess;
using HtmlToPdfWithEF.Models;
using iText.Html2pdf;
using iText.Html2pdf.Resolver.Font;
using iText.IO.Font;
using iText.IO.Source;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Font;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HtmlToPdfWithEF
{
    public class Program
    {
        public static string BASEURL = @"C:\Users\user\Desktop\HtmlToPdfWithEF\HtmlToPdfWithEF\Resources\"; // 查找 html 檔案和資源(img和CSS)的資料夾路徑
        public static string SRC = String.Format("{0}FILENAME.html", BASEURL); // html 來源路徑，用來抓取 指定 的 html 檔案

        public static string TARGET = @"C:\Users\user\Desktop\HtmlToPdfWithEF\HtmlToPdfWithEF\OutputPdf\"; // output PDF 的資料夾路徑
        public static string DEST = String.Format("{0}test.pdf", TARGET); // 輸出 PDF檔案 的路徑

        public static string[] FONTS =
           {
                @"C:\Windows\Fonts\kaiu.ttf",
                System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts),"arial.ttf"), // arial
                System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts),"kaiu.ttf") // 標楷體
            };

        public static async Task Main()
        {
            using (var db = new PointCalculationEngineContext())
            {
                Console.WriteLine("開始: " + DateTime.Now.ToString());
                Console.WriteLine("進DB撈資料" + DateTime.Now.ToString());
                List<PurchaseTransactionDetail> detailList = db.PurchaseTransactionDetail.OrderBy(x => x.SqlId).AsNoTracking().ToList(); // 255568筆 
                //List<PurchaseTransactionDetail> detailList = db.PurchaseTransactionDetail.Take(10000).OrderBy(x => x.SqlId).AsNoTracking().ToList();
                Console.WriteLine("撈出資料" + DateTime.Now.ToString());

                //設定PDF屬性
                ConverterProperties converterProperties = new ConverterProperties();
                converterProperties.SetBaseUri(BASEURL);

                //設定字型
                FontProvider fontProvider = new DefaultFontProvider(false, false, false);
                foreach (string fontPath in FONTS)
                {
                    FontProgram fontProgram = FontProgramFactory.CreateFont(fontPath);
                    fontProvider.AddFont(fontProgram);
                }
                converterProperties.SetFontProvider(fontProvider);

                // 準備 PDF 檔案
                PdfWriter writer = new PdfWriter(DEST); // DEST: 輸出 PDF檔案 到指定路徑
                PdfDocument pdf = new PdfDocument(writer); // 生成 PDF檔案
                pdf.SetDefaultPageSize(PageSize.A4.Rotate()); //將 PDF轉成橫向
                PdfMerger merger = new PdfMerger(pdf); // merger PDF 檔案用的
                Document pdfDoc = new Document(pdf);
                StringBuilder htmlStringBuilder = new StringBuilder();
                string htmlText =
                         "<table>" +
                             "<tr>" +
                                 "<th>SqlId</th>" +
                                 "<th>Id</th>" +
                                 "<th>PurchaseTransactionId</th>" +
                                 "<th>RowNumber</th>" +
                                 "<th>ItemDescription</th>" +
                             "</tr><tr>";
                htmlStringBuilder.Append(htmlText);

                Console.WriteLine("開始生成PDF檔案 " + DateTime.Now.ToString());

                var taskList = new List<Task<PdfDocument>>();
                //var taskList = new List<Task<IList<IElement>>>();

                int range = 2000;
                int times = detailList.Count / range + (detailList.Count % range > 0 ? 1 : 0);

                for (int i = 1; i <= times; i++)
                {
                    var detailListFragment = detailList.GetRange((i - 1) * range, i * range > detailList.Count ? (detailList.Count - (i - 1) * range) : range);
                    foreach (var item in detailListFragment)
                    {
                        htmlStringBuilder.Append("<tr>");
                        htmlStringBuilder.Append($"<td>{item.SqlId}</td>");
                        htmlStringBuilder.Append($"<td>{item.Id}</td>");
                        htmlStringBuilder.Append($"<td>{item.PurchaseTransactionId}</td>");
                        htmlStringBuilder.Append($"<td>{item.RowNumber}</td>");
                        htmlStringBuilder.Append($"<td>{item.ItemDescription}</td>");
                        htmlStringBuilder.Append("</tr>");
                    }
                    htmlStringBuilder.Append("</table>");
                    string combineHtml = htmlStringBuilder.ToString();
                    taskList.Add(ConvertToPdfDocumentAsync(combineHtml));

                    #region sample
                    //int delayInterval = 500 * i;
                    ///#1 使用 PdfMerger
                    //taskList.Add( Task.Run (() =>
                    //{
                    //    //await Task.Delay(delayInterval);
                    //    htmlStringBuilder.Append("</table>");
                    //    MemoryStream baos = new MemoryStream();
                    //    PdfDocument temp = new PdfDocument(new PdfWriter(baos));
                    //    HtmlConverter.ConvertToPdf(htmlStringBuilder.ToString(), temp, converterProperties);
                    //    temp = new PdfDocument(new PdfReader(new MemoryStream(baos.ToArray())));
                    //    Console.WriteLine("1");
                    //    return temp;
                    //}));

                    ///#2 使用 IElement List
                    //taskList.Add(Task.Run(async () =>
                    //{
                    //    await Task.Delay(delayInterval);
                    //    htmlStringBuilder.Append("</table>");
                    //    IList<IElement> elements = HtmlConverter.ConvertToElements(htmlStringBuilder.ToString(), converterProperties);
                    //    Console.WriteLine("1");
                    //    return elements;
                    //}));
                    #endregion

                    #region ori
                    ///#1 使用 PdfMerger
                    //htmlStringBuilder.Append("</table>");
                    //MemoryStream baos = new MemoryStream();
                    //PdfDocument temp = new PdfDocument(new PdfWriter(baos));
                    //HtmlConverter.ConvertToPdf(htmlStringBuilder.ToString(), temp, converterProperties);
                    //temp = new PdfDocument(new PdfReader(new MemoryStream(baos.ToArray())));
                    //merger.Merge(temp, 1, temp.GetNumberOfPages());
                    //temp.Close();

                    ///#2 使用 IElement List
                    //htmlStringBuilder.Append("</table>");
                    //IList<IElement> elements = HtmlConverter.ConvertToElements(htmlStringBuilder.ToString(), converterProperties);
                    //foreach (var item in elements)
                    //{
                    //    pdfDoc.Add((IBlockElement)item);
                    //}
                    #endregion

                    htmlStringBuilder.Clear();
                    htmlStringBuilder.Append("<table>");//*
                }

                //var result = await Task.WhenAll(taskList);

                //foreach (var item in result)
                //{
                //    merger.Merge(item, 1, item.GetNumberOfPages());
                //    item.Close();
                //}

                var results = Task.WhenAll(taskList);
                try
                {
                    results.Wait();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                if (results.Status == TaskStatus.RanToCompletion)
                {
                    ///#1 使用 PdfMerger
                    foreach (var item in results.Result)
                    {
                        merger.Merge(item, 1, item.GetNumberOfPages());
                        item.Close();
                    }

                    ///#2 使用 IElement List
                    //foreach (var elements in results.Result)
                    //{
                    //    for (int i = 0; i < elements.Count; i++)
                    //    {
                    //        pdfDoc.Add((IBlockElement)elements[i]);
                    //    }
                    //}
                }
                else // Display information on faulted tasks.
                {
                    foreach (var t in taskList)
                    {
                        Console.WriteLine("Task {0}: {1}", t.Id, t.Status);
                    }
                }
                pdfDoc.Close();


                //async Task<PdfDocument> ConvertToPdfDocumentAsync(string combineHtml, ConverterProperties converterProperties)
                //{
                //    return await Task.Run(() =>
                //    {
                //        ConverterProperties cp = new ConverterProperties();
                //        //htmlStringBuilder.Append("</table>");
                //        MemoryStream baos = new MemoryStream();
                //        PdfDocument temp = new PdfDocument(new PdfWriter(baos));
                //        //string combineHtml = htmlStringBuilder.ToString();
                //        HtmlConverter.ConvertToPdf(combineHtml, temp, cp);
                //        temp = new PdfDocument(new PdfReader(new MemoryStream(baos.ToArray())));
                //        Console.WriteLine("1");
                //        return temp;
                //    });
                //}
            }
            Console.WriteLine("結束: " + DateTime.Now.ToString());
        }
       private static async Task<PdfDocument> ConvertToPdfDocumentAsync(string combineHtml)
        {
            return await Task.Run(() =>
            {
                //設定PDF屬性
                ConverterProperties converterProperties = new ConverterProperties();
  
                //設定字型
                FontProvider fontProvider = new DefaultFontProvider(false, false, false);
                foreach (string fontPath in FONTS)
                {
                    FontProgram fontProgram = FontProgramFactory.CreateFont(fontPath);
                    fontProvider.AddFont(fontProgram);
                }
                converterProperties.SetFontProvider(fontProvider);

                //htmlStringBuilder.Append("</table>");
                MemoryStream baos = new MemoryStream();
                PdfDocument temp = new PdfDocument(new PdfWriter(baos));
                //string combineHtml = htmlStringBuilder.ToString();
                HtmlConverter.ConvertToPdf(combineHtml, temp, converterProperties);
                temp = new PdfDocument(new PdfReader(new MemoryStream(baos.ToArray())));
                Console.WriteLine("1");
                return temp;
            });
        }

        private static async Task<IList<IElement>> ConvertToElementAsync(string htmlText, ConverterProperties converterProperties)
        {
            IList<IElement> elements = HtmlConverter.ConvertToElements(htmlText, converterProperties);
            Console.WriteLine("1");
            return elements;
        }

        private static async Task<byte[]> ConvertToByteAsync(string htmlText, ConverterProperties converterProperties)
        {
            //byte[] tempBytes;
            //using (var memoryStream = new MemoryStream())
            //{
            //    HtmlConverter.ConvertToPdf(htmlText, memoryStream);
            //    tempBytes = memoryStream.ToArray();
            //}
            //return tempBytes;

            var stream = new MemoryStream();
            var writer = new PdfWriter(stream);
            var pdf = new PdfDocument(writer);
            var document = new Document(pdf);

            document = HtmlConverter.ConvertToDocument(htmlText, pdf, converterProperties);
            //document.Close();

            return stream.ToArray();
        }

        private static async Task<ByteArrayOutputStream> ConvertToMemoryStreamAsync(string htmlText)
        {
            ByteArrayOutputStream baos = new ByteArrayOutputStream();
            HtmlConverter.ConvertToPdf(htmlText, baos);
            return baos;
        }

        private static async Task<Document> ConvertToDocumentAsync(string htmlText, PdfWriter pdfWriter, ConverterProperties converterProperties)
        {
            PdfDocument pdf = new PdfDocument(pdfWriter); // 生成 PDF檔案
            pdf.SetDefaultPageSize(PageSize.A4.Rotate()); //將 PDF轉成橫向
            Document temp = new Document(pdf);
            temp = HtmlConverter.ConvertToDocument(htmlText, pdfWriter, converterProperties);
            return temp;
        }
    }
}