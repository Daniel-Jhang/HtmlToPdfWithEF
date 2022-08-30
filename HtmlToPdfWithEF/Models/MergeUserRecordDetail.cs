using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MergeUserRecordDetail
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyOn { get; set; }
        public string ErrorMessage { get; set; }
        public int StatusId { get; set; }
        public Guid MergeUserRecordId { get; set; }
        public string SourceTableName { get; set; }
        public string SourceTableId { get; set; }
        public string SourceData { get; set; }
        public Guid MergeId { get; set; }
    }
}
