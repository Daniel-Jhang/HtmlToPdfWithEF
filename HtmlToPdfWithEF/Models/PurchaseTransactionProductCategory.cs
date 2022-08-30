using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PurchaseTransactionProductCategory
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? PurchaseTransactionId { get; set; }
        public int? PurchaseProductCategoryId { get; set; }

        public virtual PurchaseProductCategory PurchaseProductCategory { get; set; }
        public virtual PurchaseTransaction PurchaseTransaction { get; set; }
    }
}
