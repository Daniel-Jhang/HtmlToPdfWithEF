using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ReferralCodeUsage
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid FromUserDetailId { get; set; }
        public Guid ToUserDetailId { get; set; }
        public DateTime? ModifiedTime { get; set; }

        public virtual AspNetUserDetail FromUserDetail { get; set; }
        public virtual AspNetUserDetail ToUserDetail { get; set; }
    }
}
