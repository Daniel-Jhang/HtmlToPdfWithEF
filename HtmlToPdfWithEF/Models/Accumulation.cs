using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Accumulation
    {
        public Accumulation()
        {
            BenefitsMaster = new HashSet<BenefitsMaster>();
            Tag = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EnName { get; set; }
        public int? OptionSetValue { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
        public virtual ICollection<Tag> Tag { get; set; }
    }
}
