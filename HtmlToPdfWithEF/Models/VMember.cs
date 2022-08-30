using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class VMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid UserDetailId { get; set; }
        public int? MemberStatusReasonId { get; set; }
        public string MemberStatusReason { get; set; }
    }
}
