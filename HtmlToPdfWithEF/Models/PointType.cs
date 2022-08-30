using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PointType
    {
        public PointType()
        {
            ActivityPointExpireTime = new HashSet<ActivityPointExpireTime>();
            BenefitsMaster = new HashSet<BenefitsMaster>();
            DummyPointTransaction = new HashSet<DummyPointTransaction>();
            PointTransaction = new HashSet<PointTransaction>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual ICollection<ActivityPointExpireTime> ActivityPointExpireTime { get; set; }
        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
        public virtual ICollection<DummyPointTransaction> DummyPointTransaction { get; set; }
        public virtual ICollection<PointTransaction> PointTransaction { get; set; }
    }
}
