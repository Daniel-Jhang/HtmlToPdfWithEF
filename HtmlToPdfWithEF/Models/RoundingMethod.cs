using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RoundingMethod
    {
        public RoundingMethod()
        {
            BenefitsMaster = new HashSet<BenefitsMaster>();
            CalculationGroups = new HashSet<CalculationGroups>();
            CalculationGroupsMaster = new HashSet<CalculationGroupsMaster>();
            DummyCalculationGroups = new HashSet<DummyCalculationGroups>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
        public virtual ICollection<CalculationGroups> CalculationGroups { get; set; }
        public virtual ICollection<CalculationGroupsMaster> CalculationGroupsMaster { get; set; }
        public virtual ICollection<DummyCalculationGroups> DummyCalculationGroups { get; set; }
    }
}
