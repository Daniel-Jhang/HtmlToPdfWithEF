using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PurchaseTransactionDetailCrmSync
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid PurchaseTransactionDetailId { get; set; }
        public DateTime? CrmUpdateTime { get; set; }
        public Guid? CrmId { get; set; }

        public virtual PurchaseTransactionDetail PurchaseTransactionDetail { get; set; }
    }
}
