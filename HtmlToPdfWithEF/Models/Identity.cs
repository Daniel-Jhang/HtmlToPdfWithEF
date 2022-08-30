using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Identity
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public Guid? UserId { get; set; }
        public string RefreshToken { get; set; }
        public string UserName { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
