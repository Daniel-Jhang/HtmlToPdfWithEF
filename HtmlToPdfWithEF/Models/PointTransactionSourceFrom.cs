using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PointTransactionSourceFrom
    {
        public PointTransactionSourceFrom()
        {
            DummyPointTransaction = new HashSet<DummyPointTransaction>();
            PointTransaction = new HashSet<PointTransaction>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DummyPointTransaction> DummyPointTransaction { get; set; }
        public virtual ICollection<PointTransaction> PointTransaction { get; set; }
    }
}
