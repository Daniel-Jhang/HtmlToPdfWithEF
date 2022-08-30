using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataMotherProduct
    {
        public YataMotherProduct()
        {
            YataECouponSetting = new HashSet<YataECouponSetting>();
            YataRedeemProductMaster = new HashSet<YataRedeemProductMaster>();
            YataRedeemProductStockQuota = new HashSet<YataRedeemProductStockQuota>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string Name { get; set; }

        public virtual ICollection<YataECouponSetting> YataECouponSetting { get; set; }
        public virtual ICollection<YataRedeemProductMaster> YataRedeemProductMaster { get; set; }
        public virtual ICollection<YataRedeemProductStockQuota> YataRedeemProductStockQuota { get; set; }
    }
}
