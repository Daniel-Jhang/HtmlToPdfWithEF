using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class DoubleBenefit
    {
        public DoubleBenefit()
        {
            BenefitsMasterRequireDoubleBenefit = new HashSet<BenefitsMaster>();
            BenefitsMasterRewardDoubleBenefit = new HashSet<BenefitsMaster>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public DateTime? RslModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusTypeId { get; set; }
        public string CrmId { get; set; }
        public DateTime? PointGivenDate { get; set; }
        public string Name { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string RslId { get; set; }

        public virtual LookupTable StatusType { get; set; }
        public virtual ICollection<BenefitsMaster> BenefitsMasterRequireDoubleBenefit { get; set; }
        public virtual ICollection<BenefitsMaster> BenefitsMasterRewardDoubleBenefit { get; set; }
    }
}
