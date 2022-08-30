using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Condition
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? NextControlId { get; set; }
        public Guid? CrmChannelConditionId { get; set; }
        public string LeftComparisonEntity { get; set; }
        public string LeftComparisonEntityField { get; set; }
        public Guid? LeftComparisonCrmId { get; set; }
        public string LeftComparisonValue { get; set; }
        public Guid? LeftConditionItemId { get; set; }
        public int? Operator { get; set; }
        public string RightComparisonEntity { get; set; }
        public string RightComparisonEntityField { get; set; }
        public string RightComparisonValue { get; set; }
        public bool? RightComparisonBoolValue { get; set; }
        public Guid? RightComparisonCrmId { get; set; }
        public Guid? RightConditionOptionId { get; set; }
        public int? RightConditionOptionValue { get; set; }
        public bool? IsDelete { get; set; }

        public virtual NextControl NextControl { get; set; }
        public virtual Operator OperatorNavigation { get; set; }
    }
}
