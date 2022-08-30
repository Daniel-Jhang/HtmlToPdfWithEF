using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class FlowCycleRecord
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public Guid? FlowId { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
