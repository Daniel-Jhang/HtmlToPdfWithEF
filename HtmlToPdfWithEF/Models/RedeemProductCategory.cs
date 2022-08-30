using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RedeemProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SortButtonColorIniPos { get; set; }
        public string Code { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public int? RedeemCategorySequence { get; set; }
    }
}
