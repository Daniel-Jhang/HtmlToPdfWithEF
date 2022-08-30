using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MultipleRuleLogic
    {
        public MultipleRuleLogic()
        {
            MemberScheme = new HashSet<MemberScheme>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<MemberScheme> MemberScheme { get; set; }
    }
}
