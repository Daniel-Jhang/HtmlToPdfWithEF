using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class TransactionSummaryReport
    {
        public int Id { get; set; }
        public string MerchantNo { get; set; }
        public string MerchantName { get; set; }
        public int NoofTx { get; set; }
        public string TxCurrency { get; set; }
        public string GrossAmount { get; set; }
        public string Discount { get; set; }
        public string NetAmount { get; set; }
        public bool IsDeleted { get; set; }
        public string CreateUser { get; set; }
        public DateTime CredateTime { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
