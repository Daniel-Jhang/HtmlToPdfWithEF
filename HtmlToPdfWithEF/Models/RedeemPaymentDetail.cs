using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RedeemPaymentDetail
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public string PaymentMethod { get; set; }
        public int? Currency { get; set; }
        public decimal? Amount { get; set; }
        public Guid? RedeemTransactionId { get; set; }
        public string N5CampaignId { get; set; }
        public string N5TraceNo { get; set; }
        public string N5TxnDate { get; set; }
        public string N5TxnTime { get; set; }
        public string N5HostRef { get; set; }
        public string N5CouponId { get; set; }
        public decimal? N5AuthAmt { get; set; }
        public string N5LocalCur { get; set; }
        public string N5Mid { get; set; }
        public string N5Tid { get; set; }
        public string N5Pan { get; set; }
        public string N5PaymentType { get; set; }

        public virtual RedeemTransaction RedeemTransaction { get; set; }
    }
}
