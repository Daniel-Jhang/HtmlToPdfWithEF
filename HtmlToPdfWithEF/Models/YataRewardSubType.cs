using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataRewardSubType
    {
        public YataRewardSubType()
        {
            YataECouponRecord = new HashSet<YataECouponRecord>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string Name { get; set; }
        public int? Sequence { get; set; }
        public string RewardSubTypeE { get; set; }

        public virtual ICollection<YataECouponRecord> YataECouponRecord { get; set; }
    }
}
