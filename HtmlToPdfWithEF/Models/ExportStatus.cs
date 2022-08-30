using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ExportStatus
    {
        public ExportStatus()
        {
            ReportRecord = new HashSet<ReportRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ReportRecord> ReportRecord { get; set; }
    }
}
