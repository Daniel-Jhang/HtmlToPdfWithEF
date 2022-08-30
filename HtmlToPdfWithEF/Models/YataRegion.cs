using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataRegion
    {
        public YataRegion()
        {
            AspNetUserDetail = new HashSet<AspNetUserDetail>();
            District = new HashSet<District>();
            Market = new HashSet<Market>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RegionNamec { get; set; }
        public Guid? CountryId { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmCreatedTime { get; set; }
        public Guid? CrmCreatedBy { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public Guid? CrmModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Sequence { get; set; }

        public virtual YataCountry Country { get; set; }
        public virtual ICollection<AspNetUserDetail> AspNetUserDetail { get; set; }
        public virtual ICollection<District> District { get; set; }
        public virtual ICollection<Market> Market { get; set; }
    }
}
