using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataCountryCode
    {
        public YataCountryCode()
        {
            AspNetUserDetail = new HashSet<AspNetUserDetail>();
        }

        public int Id { get; set; }
        public bool? IsDeleted { get; set; }
        public string Name { get; set; }
        public int OptionSetValue { get; set; }

        public virtual ICollection<AspNetUserDetail> AspNetUserDetail { get; set; }
    }
}
