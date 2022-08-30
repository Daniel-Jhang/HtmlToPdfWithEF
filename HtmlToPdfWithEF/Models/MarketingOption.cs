using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MarketingOption
    {
        public MarketingOption()
        {
            AspnetUserDetailMarketingOption = new HashSet<AspnetUserDetailMarketingOption>();
        }

        public Guid Id { get; set; }
        public long SqlId { get; set; }
        public string Name { get; set; }
        public int? MarketId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public int PreferenceId { get; set; }
        public int MarketingCostTypeId { get; set; }
        public bool IsVip { get; set; }

        public virtual Market Market { get; set; }
        public virtual MarketingCostType MarketingCostType { get; set; }
        public virtual Preference Preference { get; set; }
        public virtual ICollection<AspnetUserDetailMarketingOption> AspnetUserDetailMarketingOption { get; set; }
    }
}
