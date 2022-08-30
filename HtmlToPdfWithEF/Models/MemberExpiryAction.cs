using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MemberExpiryAction
    {
        public MemberExpiryAction()
        {
            MemberScheme = new HashSet<MemberScheme>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }

        public virtual ICollection<MemberScheme> MemberScheme { get; set; }
    }
}
