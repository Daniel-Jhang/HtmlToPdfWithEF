using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataRedeemTransaction
    {
        public YataRedeemTransaction()
        {
            PointTransaction = new HashSet<PointTransaction>();
            YataECouponRecord = new HashSet<YataECouponRecord>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid UserDetailId { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public string PhysicalCardNumber { get; set; }
        public int? MarketId { get; set; }
        public int? TransactionAmount { get; set; }
        public int? TypeId { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string EcouponSettingNameC { get; set; }
        public string EcouponSettingNameE { get; set; }

        public virtual Market Market { get; set; }
        public virtual LookupTable Type { get; set; }
        public virtual AspNetUserDetail UserDetail { get; set; }
        public virtual ICollection<PointTransaction> PointTransaction { get; set; }
        public virtual ICollection<YataECouponRecord> YataECouponRecord { get; set; }
    }
}
