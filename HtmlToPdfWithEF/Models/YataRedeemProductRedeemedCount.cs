using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataRedeemProductRedeemedCount
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? RedeemProductMasterId { get; set; }
        public int? MarketId { get; set; }
        public int RedeemedCount { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual Market Market { get; set; }
        public virtual YataRedeemProductMaster RedeemProductMaster { get; set; }
    }
}
