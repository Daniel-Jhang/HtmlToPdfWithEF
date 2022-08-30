using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class SendStatus
    {
        public SendStatus()
        {
            MarketingCostRecord = new HashSet<MarketingCostRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MarketingCostRecord> MarketingCostRecord { get; set; }
    }
}
