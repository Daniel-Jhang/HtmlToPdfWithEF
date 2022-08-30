using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class TagGroup
    {
        public TagGroup()
        {
            Tag = new HashSet<Tag>();
        }

        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public string Name { get; set; }
        public Guid? CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Tag> Tag { get; set; }
    }
}
