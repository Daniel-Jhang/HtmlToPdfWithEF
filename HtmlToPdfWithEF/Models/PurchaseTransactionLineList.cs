using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PurchaseTransactionLineList
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid PurchaseTransactionId { get; set; }
        public string InvoiceNumber { get; set; }
        public string LineNo { get; set; }
        public string ApplyToLine { get; set; }
        public string RetailType { get; set; }
        public Guid? ProductMasterId { get; set; }
        public string ItemCode { get; set; }
        public string Upc { get; set; }
        public decimal? Qty { get; set; }
        public decimal? OriginalAmt { get; set; }
        public decimal? NetAmt { get; set; }
        public string Psp { get; set; }
        public string PromotionId { get; set; }
        public string PromotionDesc { get; set; }
        public string Qrcode { get; set; }
        public string CouponCode { get; set; }
        public Guid? PaymentTypeId { get; set; }
        public string PayCode { get; set; }
        public string SubClassid { get; set; }

        public virtual PaymentType PaymentType { get; set; }
        public virtual YataSalesProductMaster ProductMaster { get; set; }
        public virtual PurchaseTransaction PurchaseTransaction { get; set; }
    }
}
