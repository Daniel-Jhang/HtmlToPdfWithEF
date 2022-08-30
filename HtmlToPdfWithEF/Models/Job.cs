using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Job
    {
        public Job()
        {
            AspNetUserDetail = new HashSet<AspNetUserDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string NameEn { get; set; }

        public virtual ICollection<AspNetUserDetail> AspNetUserDetail { get; set; }
    }
}
