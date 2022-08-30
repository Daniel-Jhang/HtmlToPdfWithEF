using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class DailyDetailTransactions
    {
        public int Id { get; set; }
        public string MerchantNo { get; set; }
        public string StoreNo { get; set; }
        public string StoreName { get; set; }
        public string TraceNo { get; set; }
        public string CardType { get; set; }
        public string Dcc { get; set; }
        public string CardNo { get; set; }
        public string TxCurrency { get; set; }
        public decimal TxAmt { get; set; }
        public string Mdr { get; set; }
        public decimal CommisionAmt { get; set; }
        public decimal NetAmt { get; set; }
        public DateTime TxDate { get; set; }
        public string AuthNo { get; set; }
        public string TerminalId { get; set; }
        public string ReferenceNo { get; set; }
        public string Batchno { get; set; }
        public string TxType { get; set; }
        public string FileName { get; set; }
        public bool IsDeleted { get; set; }
        public string CreateUser { get; set; }
        public DateTime CredateTime { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
