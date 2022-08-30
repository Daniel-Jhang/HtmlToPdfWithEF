using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class FlowStatus
    {
        public FlowStatus()
        {
            Flow = new HashSet<Flow>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Flow> Flow { get; set; }
    }
}
