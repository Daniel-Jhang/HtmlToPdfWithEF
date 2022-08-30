using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Activity
    {
        public Activity()
        {
            ActivityPointExpireTime = new HashSet<ActivityPointExpireTime>();
            BenefitsMaster = new HashSet<BenefitsMaster>();
            DummyPointTransactionDetail = new HashSet<DummyPointTransactionDetail>();
            MarketingCost = new HashSet<MarketingCost>();
            PointTransactionDetail = new HashSet<PointTransactionDetail>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public string RslId { get; set; }
        public DateTime? RslModifiedTime { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndDay { get; set; }

        public virtual ICollection<ActivityPointExpireTime> ActivityPointExpireTime { get; set; }
        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
        public virtual ICollection<DummyPointTransactionDetail> DummyPointTransactionDetail { get; set; }
        public virtual ICollection<MarketingCost> MarketingCost { get; set; }
        public virtual ICollection<PointTransactionDetail> PointTransactionDetail { get; set; }
    }
}
