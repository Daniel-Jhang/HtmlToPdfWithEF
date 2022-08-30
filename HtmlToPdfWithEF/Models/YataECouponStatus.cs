using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataECouponStatus
    {
        public YataECouponStatus()
        {
            EcouponRecord = new HashSet<EcouponRecord>();
            YataECouponRecord = new HashSet<YataECouponRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ChineseName { get; set; }
        public int? OptionSetValue { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<EcouponRecord> EcouponRecord { get; set; }
        public virtual ICollection<YataECouponRecord> YataECouponRecord { get; set; }
    }
}
