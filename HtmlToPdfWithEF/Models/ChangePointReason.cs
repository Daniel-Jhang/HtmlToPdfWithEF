using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ChangePointReason
    {
        public ChangePointReason()
        {
            BuChangePointReason = new HashSet<BuChangePointReason>();
            DummyPointTransaction = new HashSet<DummyPointTransaction>();
            PointTransaction = new HashSet<PointTransaction>();
        }

        public int Id { get; set; }
        public string Reason { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual ICollection<BuChangePointReason> BuChangePointReason { get; set; }
        public virtual ICollection<DummyPointTransaction> DummyPointTransaction { get; set; }
        public virtual ICollection<PointTransaction> PointTransaction { get; set; }
    }
}
