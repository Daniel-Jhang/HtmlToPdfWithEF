using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ControlStatus
    {
        public ControlStatus()
        {
            FlowControlHist = new HashSet<FlowControlHist>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<FlowControlHist> FlowControlHist { get; set; }
    }
}
