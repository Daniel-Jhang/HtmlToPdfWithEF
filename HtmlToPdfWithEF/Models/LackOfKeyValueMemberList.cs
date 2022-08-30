using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class LackOfKeyValueMemberList
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid UserDetailId { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? IsCanceled { get; set; }
        public int? SendTypeId { get; set; }

        public virtual AspNetUserDetail UserDetail { get; set; }
    }
}
