using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class BenefitType
    {
        public BenefitType()
        {
            BenefitsMaster = new HashSet<BenefitsMaster>();
        }

        public int Id { get; set; }
        public bool? IsDeleted { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }

        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
    }
}
