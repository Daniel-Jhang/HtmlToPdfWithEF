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
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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
                                 "<th>PurchaseProductCategoryId</th>" +
                                 "<th>UnitPrice</th>" +
                                 "<th>Quantity</th>" +
                                 "<th>TotalAmount</th>" +
                                 "<th>UOM</th>" +
                                 "<th>SalesProductMasterId</th>" +
                                 "<th>UpdateTimeStamp</th>" +
                                 "<th>CreateDateTime</th>" +
                                 "<th>MigrationTime</th>" +
                                 "<th>LineNo</th>" +
                                 "<th>ApplyToLine</th>" +
                                 "<th>RetailType</th>" +
                                 "<th>OriginalAmount</th>" +
                                 "<th>PSP</th>" +
                                 "<th>PromotionId</th>" +
                                 "<th>PromotionDesc</th>" +
                                 "<th>QRCode</th>" +
                                 "<th>CouponCode</th>" +
                                 "<th>PayCode</th>" +
                                 "<th>SubClassId</th>" +
                             "</tr><tr>";
                htmlStringBuilder.Append(htmlText);

                Console.WriteLine("開始生成PDF檔案 " + DateTime.Now.ToString());

                var taskList = new List<Task<PdfDocument>>();

                int range = 3000;
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
                        htmlStringBuilder.Append($"<td>{item.PurchaseProductCategoryId}</td>");
                        htmlStringBuilder.Append($"<td>{item.UnitPrice}</td>");
                        htmlStringBuilder.Append($"<td>{item.Quantity}</td>");
                        htmlStringBuilder.Append($"<td>{item.TotalAmount}</td>");
                        htmlStringBuilder.Append($"<td>{item.Uom}</td>");
                        htmlStringBuilder.Append($"<td>{item.SalesProductMasterId}</td>");
                        htmlStringBuilder.Append($"<td>{item.UpdateTimeStamp}</td>");
                        htmlStringBuilder.Append($"<td>{item.CreateDateTime}</td>");
                        htmlStringBuilder.Append($"<td>{item.MigrationTime}</td>");
                        htmlStringBuilder.Append($"<td>{item.LineNo}</td>");
                        htmlStringBuilder.Append($"<td>{item.ApplyToLine}</td>");
                        htmlStringBuilder.Append($"<td>{item.RetailType}</td>");
                        htmlStringBuilder.Append($"<td>{item.OriginalAmount}</td>");
                        htmlStringBuilder.Append($"<td>{item.Psp}</td>");
                        htmlStringBuilder.Append($"<td>{item.PromotionId}</td>");
                        htmlStringBuilder.Append($"<td>{item.PromotionDesc}</td>");
                        htmlStringBuilder.Append($"<td>{item.Qrcode}</td>");
                        htmlStringBuilder.Append($"<td>{item.CouponCode}</td>");
                        htmlStringBuilder.Append($"<td>{item.PayCode}</td>");
                        htmlStringBuilder.Append($"<td>{item.SubClassId}</td>");
                        htmlStringBuilder.Append("</tr>");
                    }
                    htmlStringBuilder.Append("</table>");
                    string combineHtml = htmlStringBuilder.ToString();
                    taskList.Add(ConvertToPdfDocumentAsync(combineHtml));

                    htmlStringBuilder.Clear();
                    htmlStringBuilder.Append("<table>");//*
                }

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
                }
                else // Display information on faulted tasks.
                {
                    foreach (var t in taskList)
                    {
                        Console.WriteLine("Task {0}: {1}", t.Id, t.Status);
                    }
                }
                pdfDoc.Close();
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

                MemoryStream baos = new MemoryStream();
                PdfDocument temp = new PdfDocument(new PdfWriter(baos));
                temp.SetDefaultPageSize(PageSize.A4.Rotate()); //將 PDF轉成橫向
                HtmlConverter.ConvertToPdf(combineHtml, temp, converterProperties);
                temp = new PdfDocument(new PdfReader(new MemoryStream(baos.ToArray())));
                //Console.WriteLine("1");
                return temp;
            });
        }
    }
}
