using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataUserDetailInterest
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid InterestId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public bool IsEnable { get; set; }

        public virtual YataInterest Interest { get; set; }
        public virtual AspNetUserDetail User { get; set; }
    }
}
