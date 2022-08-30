using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class FlowControlHist
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? ControlId { get; set; }
        public int? StatusId { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public Guid? FlowId { get; set; }
        public Guid? CycleId { get; set; }

        public virtual Control Control { get; set; }
        public virtual ControlStatus Status { get; set; }
    }
}
