using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PurchaseTransactionCrmSync
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid PurchaseTransactionId { get; set; }
        public DateTime? CrmUpdateTime { get; set; }
        public Guid? CrmId { get; set; }

        public virtual PurchaseTransaction PurchaseTransaction { get; set; }
    }
}
