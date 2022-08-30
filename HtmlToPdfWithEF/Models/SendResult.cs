using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class SendResult
    {
        public SendResult()
        {
            MarketingCostResult = new HashSet<MarketingCostResult>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }

        public virtual ICollection<MarketingCostResult> MarketingCostResult { get; set; }
    }
}
