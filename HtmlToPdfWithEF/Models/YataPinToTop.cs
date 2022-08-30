using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataPinToTop
    {
        public YataPinToTop()
        {
            YataPromotionBanner = new HashSet<YataPromotionBanner>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<YataPromotionBanner> YataPromotionBanner { get; set; }
    }
}
