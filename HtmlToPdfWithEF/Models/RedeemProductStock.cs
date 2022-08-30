using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RedeemProductStock
    {
        public int Id { get; set; }
        public Guid RedeemProductId { get; set; }
        public decimal Quantity { get; set; }
        public int MarketId { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual Market Market { get; set; }
        public virtual RedeemProduct RedeemProduct { get; set; }
    }
}
