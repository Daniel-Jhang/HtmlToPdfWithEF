using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string LogingName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
        public string CreateUser { get; set; }
        public DateTime CredateTime { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
