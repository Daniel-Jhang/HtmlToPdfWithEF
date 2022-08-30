using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Token
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public string RefreshToken { get; set; }
        public Guid? UserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? ExpiresIn { get; set; }
    }
}
