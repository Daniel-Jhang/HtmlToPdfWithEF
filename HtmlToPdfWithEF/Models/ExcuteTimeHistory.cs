using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ExcuteTimeHistory
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public Guid? ControlId { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public int? ExecuteCounts { get; set; }

        public virtual Control Control { get; set; }
    }
}
