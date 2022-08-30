using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataECouponMarket
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid ECouponSettingId { get; set; }
        public int MarketId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual YataECouponSetting ECouponSetting { get; set; }
        public virtual Market Market { get; set; }
    }
}
