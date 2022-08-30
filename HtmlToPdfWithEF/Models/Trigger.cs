using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Trigger
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public Guid ControlId { get; set; }
        public Guid ControlItemId { get; set; }
        public DateTime StartTime { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? ExecuteSyncDate { get; set; }
        public int? ExecuteCount { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public bool? IsRunned { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public int? NewPid { get; set; }
        public Guid? CycleId { get; set; }

        public virtual Control Control { get; set; }
        public virtual ControlItem ControlItem { get; set; }
    }
}
