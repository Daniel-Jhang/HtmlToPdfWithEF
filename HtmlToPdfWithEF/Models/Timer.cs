using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Timer
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public Guid ControlId { get; set; }
        public DateTime? StartTime { get; set; }
        public int? Count { get; set; }
        public int? TimeUnitId { get; set; }
        public Guid ControlItemId { get; set; }
        public bool? IsDetete { get; set; }
        public DateTime? ExecuteSyncDate { get; set; }

        public virtual Control Control { get; set; }
        public virtual ControlItem ControlItem { get; set; }
        public virtual TimeUnit TimeUnit { get; set; }
    }
}
