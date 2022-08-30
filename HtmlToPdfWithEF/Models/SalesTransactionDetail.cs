using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class SalesTransactionDetail
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid SalesRedeemProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UniPrice { get; set; }
        public decimal TotalAmount { get; set; }
        public int CurrencyId { get; set; }
        public int ShopId { get; set; }
        public Guid SalesTransactionId { get; set; }
        public bool NavIsSync { get; set; }
        public int? ItemNumber { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual RedeemProduct SalesRedeemProduct { get; set; }
        public virtual SalesTransaction SalesTransaction { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
