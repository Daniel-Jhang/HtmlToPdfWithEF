using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PurchaseProductCategory
    {
        public PurchaseProductCategory()
        {
            DummyPurchaseTransactionProductCategory = new HashSet<DummyPurchaseTransactionProductCategory>();
            PurchaseTransactionProductCategory = new HashSet<PurchaseTransactionProductCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<DummyPurchaseTransactionProductCategory> DummyPurchaseTransactionProductCategory { get; set; }
        public virtual ICollection<PurchaseTransactionProductCategory> PurchaseTransactionProductCategory { get; set; }
    }
}
