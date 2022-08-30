using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class BuChangePointReason
    {
        public int Id { get; set; }
        public int? MemberSchemeTypeId { get; set; }
        public int? ChangePointReasonId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ChangePointReason ChangePointReason { get; set; }
        public virtual MemberSchemeType MemberSchemeType { get; set; }
    }
}
