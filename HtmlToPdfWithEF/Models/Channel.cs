using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Channel
    {
        public Channel()
        {
            Member = new HashSet<Member>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }

        public virtual ICollection<Member> Member { get; set; }
    }
}
