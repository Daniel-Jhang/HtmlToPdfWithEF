using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataRegisterLog
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? UserDetailId { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorMessageDetail { get; set; }
        public DateTime? CreateTime { get; set; }
        public string RequestJson { get; set; }
    }
}
