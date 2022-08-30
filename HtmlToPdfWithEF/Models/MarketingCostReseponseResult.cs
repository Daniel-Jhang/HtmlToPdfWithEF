using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MarketingCostReseponseResult
    {
        public MarketingCostReseponseResult()
        {
            MarketingCostResult = new HashSet<MarketingCostResult>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MarketingCostResult> MarketingCostResult { get; set; }
    }
}
