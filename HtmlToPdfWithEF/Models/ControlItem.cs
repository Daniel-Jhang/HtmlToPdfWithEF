using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ControlItem
    {
        public ControlItem()
        {
            Control = new HashSet<Control>();
            Timer = new HashSet<Timer>();
            Trigger = new HashSet<Trigger>();
        }

        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public Guid? CrmId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public Guid ControlTypeId { get; set; }
        public bool? IsDelete { get; set; }
        public string Fields { get; set; }
        public string FieldTypes { get; set; }

        public virtual ControlType ControlType { get; set; }
        public virtual ICollection<Control> Control { get; set; }
        public virtual ICollection<Timer> Timer { get; set; }
        public virtual ICollection<Trigger> Trigger { get; set; }
    }
}
