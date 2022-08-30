using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class HousingEstate
    {
        public HousingEstate()
        {
            AspNetUserDetail = new HashSet<AspNetUserDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? MarketId { get; set; }
        public int? DistrictId { get; set; }
        public string Code { get; set; }
        public bool IsOther { get; set; }

        public virtual District District { get; set; }
        public virtual Market Market { get; set; }
        public virtual ICollection<AspNetUserDetail> AspNetUserDetail { get; set; }
    }
}
