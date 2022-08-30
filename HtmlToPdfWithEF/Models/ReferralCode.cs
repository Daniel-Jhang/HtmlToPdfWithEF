using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ReferralCode
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public int? ShopId { get; set; }
        public string Code { get; set; }
        public Guid UserDetailId { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual AspNetUserDetail UserDetail { get; set; }
    }
}
