using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class District
    {
        public District()
        {
            AspNetUserDetailDistrict = new HashSet<AspNetUserDetail>();
            AspNetUserDetailPrimaryDistrictNavigation = new HashSet<AspNetUserDetail>();
            HousingEstate = new HashSet<HousingEstate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public DateTime? CrmCreatedTime { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string CrmId { get; set; }
        public int? AreaId { get; set; }
        public Guid? Region { get; set; }
        public int? Sequence { get; set; }

        public virtual Area Area { get; set; }
        public virtual YataRegion RegionNavigation { get; set; }
        public virtual ICollection<AspNetUserDetail> AspNetUserDetailDistrict { get; set; }
        public virtual ICollection<AspNetUserDetail> AspNetUserDetailPrimaryDistrictNavigation { get; set; }
        public virtual ICollection<HousingEstate> HousingEstate { get; set; }
    }
}
