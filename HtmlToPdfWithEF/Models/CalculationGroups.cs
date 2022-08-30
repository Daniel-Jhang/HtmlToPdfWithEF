using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class CalculationGroups
    {
        public CalculationGroups()
        {
            PointTransactionDetail = new HashSet<PointTransactionDetail>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MultipleRuleLogicId { get; set; }
        public int RoundingMethodId { get; set; }
        public int RoundingDigitId { get; set; }
        public decimal Point { get; set; }

        public virtual RoundingDigit RoundingDigit { get; set; }
        public virtual RoundingMethod RoundingMethod { get; set; }
        public virtual ICollection<PointTransactionDetail> PointTransactionDetail { get; set; }
    }
}
