using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class TimeUnit
    {
        public TimeUnit()
        {
            Timer = new HashSet<Timer>();
        }

        public int Id { get; set; }
        public string UnitName { get; set; }
        public double Second { get; set; }
        public string ChineseUnitName { get; set; }
        public int? CrmOptionSet { get; set; }

        public virtual ICollection<Timer> Timer { get; set; }
    }
}
