using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PayKind
    {
        public PayKind()
        {
            PaymentType = new HashSet<PaymentType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? MemberschemeId { get; set; }

        public virtual ICollection<PaymentType> PaymentType { get; set; }
    }
}
