using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MarketingCostImage
    {
        public int SqlId { get; set; }
        public string Id { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public string MarketingCostCrmId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string ContentType { get; set; }
        public string InputFileName { get; set; }
    }
}
