using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Pos
    {
        public Pos()
        {
            EcouponRecord = new HashSet<EcouponRecord>();
        }

        public int SqlId { get; set; }
        public string Id { get; set; }
        public string PosId { get; set; }
        public int? ShopId { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNo { get; set; }
        public string BankBranchNo { get; set; }
        public string BankCode { get; set; }
        public string MerchantNo { get; set; }
        public DateTime? MigrationTime { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual ICollection<EcouponRecord> EcouponRecord { get; set; }
    }
}
