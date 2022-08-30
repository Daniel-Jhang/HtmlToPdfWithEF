using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataRedeemProductMaster
    {
        public YataRedeemProductMaster()
        {
            YataECouponRecord = new HashSet<YataECouponRecord>();
            YataRedeemProductRedeemedCount = new HashSet<YataRedeemProductRedeemedCount>();
            YataRedeemProductStockQuota = new HashSet<YataRedeemProductStockQuota>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string Name { get; set; }
        public Guid? MotherProductId { get; set; }
        public string RewardId { get; set; }
        public string Upc { get; set; }
        public string SpecC { get; set; }
        public string SpecE { get; set; }
        public bool? QuotaByStore { get; set; }

        public virtual YataMotherProduct MotherProduct { get; set; }
        public virtual ICollection<YataECouponRecord> YataECouponRecord { get; set; }
        public virtual ICollection<YataRedeemProductRedeemedCount> YataRedeemProductRedeemedCount { get; set; }
        public virtual ICollection<YataRedeemProductStockQuota> YataRedeemProductStockQuota { get; set; }
    }
}
