using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class DummyPurchaseTransactionDetail
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? PurchaseTransactionId { get; set; }
        public int RowNumber { get; set; }
        public string ItemDescription { get; set; }
        public int? PurchaseProductCategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public string Uom { get; set; }
        public Guid? SalesProductMasterId { get; set; }
        public DateTime? UpdateTimeStamp { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LineNo { get; set; }
        public string ApplyToLine { get; set; }
        public string RetailType { get; set; }
        public decimal? OriginalAmount { get; set; }
        public string Psp { get; set; }
        public string PromotionId { get; set; }
        public string PromotionDesc { get; set; }
        public string Qrcode { get; set; }
        public string CouponCode { get; set; }
        public string PayCode { get; set; }
        public string SubClassId { get; set; }

        public virtual DummyPurchaseTransaction PurchaseTransaction { get; set; }
        public virtual YataSalesProductMaster SalesProductMaster { get; set; }
    }
}
