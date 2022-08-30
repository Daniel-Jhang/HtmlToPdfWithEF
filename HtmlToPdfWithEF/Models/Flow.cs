using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Flow
    {
        public Flow()
        {
            Control = new HashSet<Control>();
            MarketingCost = new HashSet<MarketingCost>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int SqlId { get; set; }
        public Guid? CampaignFlowCrmId { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public DateTime? PublishTime { get; set; }
        public bool? IsCycle { get; set; }
        public DateTime? FlowEndTime { get; set; }

        public virtual FlowStatus Status { get; set; }
        public virtual ICollection<Control> Control { get; set; }
        public virtual ICollection<MarketingCost> MarketingCost { get; set; }
    }
}
