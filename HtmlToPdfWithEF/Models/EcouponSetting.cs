using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class EcouponSetting
    {
        public EcouponSetting()
        {
            EcouponRecord = new HashSet<EcouponRecord>();
            EcouponStock = new HashSet<EcouponStock>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ChineseName { get; set; }
        public decimal? Discount { get; set; }
        public int? EcouponTypeId { get; set; }
        public int? EcouponRedemptionPeriodId { get; set; }
        public DateTime? RedeemFrom { get; set; }
        public DateTime? RedeemTo { get; set; }
        public int? EcouponValidationTypeId { get; set; }
        public int? EcouponValidationPeriodId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public decimal? TransactionLowestLimit { get; set; }
        public decimal? ValueCeiling { get; set; }
        public int? RedemptionTime { get; set; }
        public int? Quantity { get; set; }
        public int? RemainingEcouponQuantity { get; set; }
        public string NavitemCode { get; set; }
        public string CrmId { get; set; }
        public Guid? RedeemProductId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? Value { get; set; }

        public virtual EcouponRedemptionPeriod EcouponRedemptionPeriod { get; set; }
        public virtual EcouponType EcouponType { get; set; }
        public virtual EcouponValidationPeriod EcouponValidationPeriod { get; set; }
        public virtual ECouponValidationType EcouponValidationType { get; set; }
        public virtual RedeemProduct RedeemProduct { get; set; }
        public virtual ICollection<EcouponRecord> EcouponRecord { get; set; }
        public virtual ICollection<EcouponStock> EcouponStock { get; set; }
    }
}
