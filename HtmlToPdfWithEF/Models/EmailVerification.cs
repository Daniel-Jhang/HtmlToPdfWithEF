using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class EmailVerification
    {
        public int Id { get; set; }
        public Guid VerifiedSqlId { get; set; }
        public string Email { get; set; }
        public DateTime? VerifiedTime { get; set; }
        public Guid? UserDetailId { get; set; }
        public string Code { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual AspNetUserDetail UserDetail { get; set; }
    }
}
