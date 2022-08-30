using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MemberStatusReason
    {
        public MemberStatusReason()
        {
            Member = new HashSet<Member>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ChineseName { get; set; }
        public int? OptionSetValue { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Member> Member { get; set; }
    }
}
