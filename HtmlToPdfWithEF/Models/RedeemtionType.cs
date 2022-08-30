using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RedeemtionType
    {
        public RedeemtionType()
        {
            EcouponRecord = new HashSet<EcouponRecord>();
            RedeemTransaction = new HashSet<RedeemTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual ICollection<EcouponRecord> EcouponRecord { get; set; }
        public virtual ICollection<RedeemTransaction> RedeemTransaction { get; set; }
    }
}
