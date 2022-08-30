using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ReStarter
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public int? Count { get; set; }
        public int? TimeUnitId { get; set; }
        public bool? IsDelete { get; set; }
        public int? ExecuteCount { get; set; }
        public Guid? ControlId { get; set; }
        public DateTime? LastExecuteTime { get; set; }
        public DateTime? FirstExecuteTime { get; set; }
        public Guid ControlItemId { get; set; }

        public virtual Control Control { get; set; }
    }
}
