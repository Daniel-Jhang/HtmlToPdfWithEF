using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ReportRecord
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string FileName { get; set; }
        public int? AzureStatus { get; set; }
        public int ExportStatus { get; set; }
        public DateTime? BlobCreateTime { get; set; }
        public DateTime? AdfStartTime { get; set; }
        public int? Count { get; set; }
        public string AdfRunId { get; set; }
        public string StaticListId { get; set; }
        public DateTime? AdfEndTime { get; set; }
        public string ErrorMessage { get; set; }
        public bool? IsLocked { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime? LockTime { get; set; }
        public int ReportType { get; set; }

        public virtual AzureStatus AzureStatusNavigation { get; set; }
        public virtual ExportStatus ExportStatusNavigation { get; set; }
        public virtual ReportType ReportTypeNavigation { get; set; }
    }
}
