using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Switch
    {
        public int CrmId { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool Status { get; set; }
        public string Controller { get; set; }
        public int ControllerOrder { get; set; }
        public string Description { get; set; }
    }
}
