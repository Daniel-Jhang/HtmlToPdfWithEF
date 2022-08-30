using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class SendType
    {
        public SendType()
        {
            MarketingCostRecord = new HashSet<MarketingCostRecord>();
            MarketingCostType = new HashSet<MarketingCostType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MarketingCostRecord> MarketingCostRecord { get; set; }
        public virtual ICollection<MarketingCostType> MarketingCostType { get; set; }
    }
}
