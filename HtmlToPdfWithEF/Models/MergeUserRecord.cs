using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MergeUserRecord
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime? ModifyOn { get; set; }
        public byte[] RowVersion { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusId { get; set; }
        public Guid ToUserDetailId { get; set; }
        public Guid FromUserDetailId { get; set; }
        public string ErrorMessage { get; set; }
        public Guid CurrentMergeId { get; set; }

        public virtual AspNetUserDetail FromUserDetail { get; set; }
        public virtual MergeUserStatus Status { get; set; }
        public virtual AspNetUserDetail ToUserDetail { get; set; }
    }
}
