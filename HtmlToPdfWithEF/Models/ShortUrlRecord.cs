using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ShortUrlRecord
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string OriginalUrl { get; set; }
        public Guid? MarketingCostRecordId { get; set; }
        public string ShortUrlCode { get; set; }

        public virtual MarketingCostRecord MarketingCostRecord { get; set; }
    }
}
