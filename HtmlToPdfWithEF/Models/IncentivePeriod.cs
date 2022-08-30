using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class IncentivePeriod
    {
        public IncentivePeriod()
        {
            BenefitsMaster = new HashSet<BenefitsMaster>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
    }
}
