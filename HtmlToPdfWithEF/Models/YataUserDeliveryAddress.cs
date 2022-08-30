using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataUserDeliveryAddress
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid UserDetailId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool DefaultAddress { get; set; }
        public Guid? Country { get; set; }
        public Guid Region { get; set; }
        public int DistrictId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public bool IsDeleted { get; set; }

        public virtual AspNetUserDetail UserDetail { get; set; }
    }
}
