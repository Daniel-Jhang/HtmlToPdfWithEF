using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class SmsstatusCode
    {
        public SmsstatusCode()
        {
            MarketingCostResultSmsstatusCode = new HashSet<MarketingCostResult>();
            MarketingCostResultSmsstatusFlagStatusCode = new HashSet<MarketingCostResult>();
        }

        public int Id { get; set; }
        public string StatusFlag { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MarketingCostResult> MarketingCostResultSmsstatusCode { get; set; }
        public virtual ICollection<MarketingCostResult> MarketingCostResultSmsstatusFlagStatusCode { get; set; }
    }
}
