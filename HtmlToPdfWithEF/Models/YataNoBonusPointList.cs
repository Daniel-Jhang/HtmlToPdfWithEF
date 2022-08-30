using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataNoBonusPointList
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string Name { get; set; }
        public Guid? SalesProductMasterId { get; set; }
    }
}
