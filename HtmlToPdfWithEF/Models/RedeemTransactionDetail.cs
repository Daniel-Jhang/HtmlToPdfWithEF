using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RedeemTransactionDetail
    {
        public RedeemTransactionDetail()
        {
            EcouponRecord = new HashSet<EcouponRecord>();
        }

        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid RedeemProductId { get; set; }
        public int? ItemNumber { get; set; }
        public decimal Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? AmountDiscount { get; set; }
        public decimal? FinnalAmount { get; set; }
        public decimal? UnitPoint { get; set; }
        public decimal? TotalPoints { get; set; }
        public decimal? PointsDiscount { get; set; }
        public decimal? FinnalPoints { get; set; }
        public int? CurrencyId { get; set; }
        public Guid? RedeemTransactionId { get; set; }
        public bool NavIsSync { get; set; }
        public bool? IsBundle { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual RedeemProduct RedeemProduct { get; set; }
        public virtual RedeemTransaction RedeemTransaction { get; set; }
        public virtual ICollection<EcouponRecord> EcouponRecord { get; set; }
    }
}
