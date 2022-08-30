using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MarketingCostType
    {
        public MarketingCostType()
        {
            MarketingCost = new HashSet<MarketingCost>();
            MarketingOption = new HashSet<MarketingOption>();
            Tag = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public Guid? CrmId { get; set; }
        public string Name { get; set; }
        public bool? CanAddToAutoFlow { get; set; }
        public int? TypeId { get; set; }
        public bool? IsShowOnMarketingReport { get; set; }
        public int? SendTypeId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual SendType SendType { get; set; }
        public virtual ICollection<MarketingCost> MarketingCost { get; set; }
        public virtual ICollection<MarketingOption> MarketingOption { get; set; }
        public virtual ICollection<Tag> Tag { get; set; }
    }
}
