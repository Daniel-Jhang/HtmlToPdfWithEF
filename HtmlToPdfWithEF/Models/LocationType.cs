using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class LocationType
    {
        public LocationType()
        {
            Market = new HashSet<Market>();
            Shop = new HashSet<Shop>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string CrmId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Market> Market { get; set; }
        public virtual ICollection<Shop> Shop { get; set; }
    }
}
