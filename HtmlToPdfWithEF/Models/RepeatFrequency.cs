using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RepeatFrequency
    {
        public RepeatFrequency()
        {
            BenefitsMaster = new HashSet<BenefitsMaster>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
    }
}
