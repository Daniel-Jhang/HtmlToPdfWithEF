using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class TagCategory
    {
        public TagCategory()
        {
            Tag = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EnName { get; set; }
        public int Code { get; set; }
        public Guid? CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual ICollection<Tag> Tag { get; set; }
    }
}
