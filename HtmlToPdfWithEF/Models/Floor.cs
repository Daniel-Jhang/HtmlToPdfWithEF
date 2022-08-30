using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Floor
    {
        public Floor()
        {
            Shop = new HashSet<Shop>();
            Tag = new HashSet<Tag>();
        }

        public Guid Id { get; set; }
        public long SqlId { get; set; }
        public string Name { get; set; }
        public int FloorIndex { get; set; }
        public int MarketId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Market Market { get; set; }
        public virtual ICollection<Shop> Shop { get; set; }
        public virtual ICollection<Tag> Tag { get; set; }
    }
}
