using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class NextControl
    {
        public NextControl()
        {
            Condition = new HashSet<Condition>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid PreviousControlId { get; set; }
        public Guid NextControlId { get; set; }
        public string PathText { get; set; }
        public bool? IsDelete { get; set; }
        public int? Priority { get; set; }

        public virtual Control PreviousControl { get; set; }
        public virtual ICollection<Condition> Condition { get; set; }
    }
}
