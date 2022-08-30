using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataCountry
    {
        public YataCountry()
        {
            AspNetUserDetail = new HashSet<AspNetUserDetail>();
            YataRegion = new HashSet<YataRegion>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameC { get; set; }
        public string Code { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmCreatedTime { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Sequence { get; set; }

        public virtual ICollection<AspNetUserDetail> AspNetUserDetail { get; set; }
        public virtual ICollection<YataRegion> YataRegion { get; set; }
    }
}
