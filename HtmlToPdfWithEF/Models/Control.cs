using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Control
    {
        public Control()
        {
            ExcuteTimeHistory = new HashSet<ExcuteTimeHistory>();
            FlowControlHist = new HashSet<FlowControlHist>();
            NextControl = new HashSet<NextControl>();
            ReStarter = new HashSet<ReStarter>();
            Timer = new HashSet<Timer>();
            Trigger = new HashSet<Trigger>();
        }

        public int SqlId { get; set; }
        public string DisplayName { get; set; }
        public Guid Id { get; set; }
        public Guid FlowId { get; set; }
        public Guid ControlTypeId { get; set; }
        public int? StatusId { get; set; }
        public Guid? MarketingCostCrmId { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? ControlItemId { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public Guid? Pid { get; set; }
        public int? NewPid { get; set; }
        public Guid? MarketingListCrmId { get; set; }
        public string PositionTop { get; set; }
        public string PositionLeft { get; set; }

        public virtual ControlItem ControlItem { get; set; }
        public virtual ControlType ControlType { get; set; }
        public virtual Flow Flow { get; set; }
        public virtual ICollection<ExcuteTimeHistory> ExcuteTimeHistory { get; set; }
        public virtual ICollection<FlowControlHist> FlowControlHist { get; set; }
        public virtual ICollection<NextControl> NextControl { get; set; }
        public virtual ICollection<ReStarter> ReStarter { get; set; }
        public virtual ICollection<Timer> Timer { get; set; }
        public virtual ICollection<Trigger> Trigger { get; set; }
    }
}
