using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class TagCustCategory
    {
        public TagCustCategory()
        {
            Tag = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public Guid? CrmId { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual ICollection<Tag> Tag { get; set; }
    }
}
