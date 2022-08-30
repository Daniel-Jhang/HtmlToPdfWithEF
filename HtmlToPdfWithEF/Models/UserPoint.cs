using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class UserPoint
    {
        public int Id { get; set; }
        public Guid UserDetailId { get; set; }
        public decimal Point { get; set; }
        public int? Year { get; set; }
        public byte[] Rowversion { get; set; }
        public Guid? ActivityPointExpireTimeId { get; set; }
        public DateTime? ExpireDate { get; set; }

        public virtual ActivityPointExpireTime ActivityPointExpireTime { get; set; }
        public virtual AspNetUserDetail UserDetail { get; set; }
    }
}
