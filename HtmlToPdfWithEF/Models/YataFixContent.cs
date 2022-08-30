using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataFixContent
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public int? FixContentId { get; set; }
        public int? Sequence { get; set; }
        public int? LanguageId { get; set; }
        public string ContentCode { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string DetailPath { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
