using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ControlType
    {
        public ControlType()
        {
            Control = new HashSet<Control>();
            ControlItem = new HashSet<ControlItem>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string ClassName { get; set; }
        public string Color { get; set; }
        public string Shape { get; set; }
        public string Icon { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<Control> Control { get; set; }
        public virtual ICollection<ControlItem> ControlItem { get; set; }
    }
}
