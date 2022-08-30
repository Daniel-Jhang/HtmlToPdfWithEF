using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PushClick
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid MarketingCostResultId { get; set; }
        public string Url { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual MarketingCostResult MarketingCostResult { get; set; }
    }
}
