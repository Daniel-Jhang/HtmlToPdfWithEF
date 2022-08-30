using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class AgeGroup
    {
        public AgeGroup()
        {
            AspNetUserDetail = new HashSet<AspNetUserDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? AgeGroupOptionSet { get; set; }
        public string AgeGroupEng { get; set; }

        public virtual ICollection<AspNetUserDetail> AspNetUserDetail { get; set; }
    }
}
