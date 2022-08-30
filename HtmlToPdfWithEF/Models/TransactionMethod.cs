using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class TransactionMethod
    {
        public TransactionMethod()
        {
            DummyPointTransaction = new HashSet<DummyPointTransaction>();
            PointTransaction = new HashSet<PointTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DummyPointTransaction> DummyPointTransaction { get; set; }
        public virtual ICollection<PointTransaction> PointTransaction { get; set; }
    }
}
