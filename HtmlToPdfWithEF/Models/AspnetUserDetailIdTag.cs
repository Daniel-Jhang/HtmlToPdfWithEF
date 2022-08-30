using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class AspnetUserDetailIdTag
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public Guid? TagId { get; set; }
        public Guid? AspnetUserDetailId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDelete { get; set; }
        public string Name { get; set; }

        public virtual AspNetUserDetail AspnetUserDetail { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
