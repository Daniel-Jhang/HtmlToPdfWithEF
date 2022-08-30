using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class DummyCalculationGroups
    {
        public DummyCalculationGroups()
        {
            DummyPointTransactionDetail = new HashSet<DummyPointTransactionDetail>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MultipleRuleLogicId { get; set; }
        public int RoundingMethodId { get; set; }
        public int RoundingDigitId { get; set; }
        public decimal Point { get; set; }

        public virtual RoundingDigit RoundingDigit { get; set; }
        public virtual RoundingMethod RoundingMethod { get; set; }
        public virtual ICollection<DummyPointTransactionDetail> DummyPointTransactionDetail { get; set; }
    }
}
