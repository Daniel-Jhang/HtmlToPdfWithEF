using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataPointHistoryType
    {
        public YataPointHistoryType()
        {
            DummyPurchaseTransaction = new HashSet<DummyPurchaseTransaction>();
            PurchaseTransaction = new HashSet<PurchaseTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Namec { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<DummyPurchaseTransaction> DummyPurchaseTransaction { get; set; }
        public virtual ICollection<PurchaseTransaction> PurchaseTransaction { get; set; }
    }
}
