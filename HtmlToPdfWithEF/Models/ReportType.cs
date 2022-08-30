using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ReportType
    {
        public ReportType()
        {
            ReportRecord = new HashSet<ReportRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ReportRecord> ReportRecord { get; set; }
    }
}
