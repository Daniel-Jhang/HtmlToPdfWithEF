using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class CalculationGroupsMaster
    {
        public CalculationGroupsMaster()
        {
            BenefitsMaster = new HashSet<BenefitsMaster>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? MultipleRuleLogicId { get; set; }
        public int? RoundingMethodId { get; set; }
        public int? RoundingDigitId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string CrmId { get; set; }
        public int? RslId { get; set; }
        public DateTime? RslModifiedTime { get; set; }

        public virtual RoundingDigit RoundingDigit { get; set; }
        public virtual RoundingMethod RoundingMethod { get; set; }
        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
    }
}
