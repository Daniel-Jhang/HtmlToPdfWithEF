using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class NavPurchaseOrderRequest
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string NavPurchaseOrderNo { get; set; }
        public int MarketId { get; set; }
        public DateTime? PurchaseOrderDate { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public string VendorName { get; set; }
        public bool IsReceiptComplete { get; set; }
        public DateTime? SyncDateTime { get; set; }
        public DateTime? ReceiptCompleteDate { get; set; }

        public virtual Market Market { get; set; }
    }
}
