using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PurchaseTransactionDailySubtotal
    {
        public int SqlId { get; set; }
        public Guid? UserDetailId { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public decimal? AccumulatedAmount { get; set; }
        public DateTime? Timestamp { get; set; }
        public byte? MemberStatus { get; set; }
        public DateTime? AccumulationPeriodStart { get; set; }
        public DateTime? AccumulationPeriodEnd { get; set; }
    }
}
