using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MarketingCostRecord
    {
        public MarketingCostRecord()
        {
            MarketingCostResult = new HashSet<MarketingCostResult>();
            ShortUrlRecord = new HashSet<ShortUrlRecord>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int? SendTypeId { get; set; }
        public string TargetField { get; set; }
        public string SendContent { get; set; }
        public string Image { get; set; }
        public string DeepLinkCode { get; set; }
        public Guid CrmId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? SendTime { get; set; }
        public int? SendStatusId { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public int SendCount { get; set; }
        public int? RecipientCount { get; set; }
        public Guid? FlowCycleRecordId { get; set; }

        public virtual SendStatus SendStatus { get; set; }
        public virtual SendType SendType { get; set; }
        public virtual ICollection<MarketingCostResult> MarketingCostResult { get; set; }
        public virtual ICollection<ShortUrlRecord> ShortUrlRecord { get; set; }
    }
}
