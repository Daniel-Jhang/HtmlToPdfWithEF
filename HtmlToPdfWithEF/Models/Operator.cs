using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Operator
    {
        public Operator()
        {
            Condition = new HashSet<Condition>();
        }

        public int SqlId { get; set; }
        public string OperatorSymbol { get; set; }

        public virtual ICollection<Condition> Condition { get; set; }
    }
}
