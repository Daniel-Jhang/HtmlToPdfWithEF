using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class TransactionStatus
    {
        public int Id { get; set; }
        public Guid? PurchaseTransactionId { get; set; }
        public int ProcessStatusId { get; set; }

        public virtual LookupTable ProcessStatus { get; set; }
        public virtual PurchaseTransaction PurchaseTransaction { get; set; }
    }
}
