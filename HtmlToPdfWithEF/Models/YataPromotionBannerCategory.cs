using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataPromotionBannerCategory
    {
        public YataPromotionBannerCategory()
        {
            YataPromotionBanner = new HashSet<YataPromotionBanner>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public bool? IsDeleted { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string NameC { get; set; }
        public string NameE { get; set; }
        public int? Order { get; set; }

        public virtual ICollection<YataPromotionBanner> YataPromotionBanner { get; set; }
    }
}
