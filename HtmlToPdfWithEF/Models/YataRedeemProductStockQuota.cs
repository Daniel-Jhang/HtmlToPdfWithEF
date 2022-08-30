using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataRedeemProductStockQuota
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? MotherProductId { get; set; }
        public Guid? RedeemProductMasterId { get; set; }
        public int? MarketId { get; set; }
        public int? Quota { get; set; }
        public DateTime? CreateDateTime { get; set; }

        public virtual Market Market { get; set; }
        public virtual YataMotherProduct MotherProduct { get; set; }
        public virtual YataRedeemProductMaster RedeemProductMaster { get; set; }
    }
}
