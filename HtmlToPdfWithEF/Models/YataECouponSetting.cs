using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataECouponSetting
    {
        public YataECouponSetting()
        {
            BenefitsMaster = new HashSet<BenefitsMaster>();
            YataECouponMarket = new HashSet<YataECouponMarket>();
            YataECouponRecord = new HashSet<YataECouponRecord>();
            YataReedemImage = new HashSet<YataReedemImage>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid MotherProductId { get; set; }
        public string ECouponId { get; set; }
        public int? ECouponTypeId { get; set; }
        public int? RewardIssuingTypeId { get; set; }
        public Guid? RewardSubTypeId { get; set; }
        public int? RequierdPointId { get; set; }
        public bool? RewardGroup { get; set; }
        public bool? PinToTop { get; set; }
        public bool? Redeemable { get; set; }
        public bool? Testing { get; set; }
        public Guid? TestingMemberSchemeId { get; set; }
        public int? MemberQuota { get; set; }
        public int? ECouponRedemptionTime { get; set; }
        public Guid? MarketingListId { get; set; }
        public int? ECouponValue { get; set; }
        public DateTime? ECouponGenerationDateTime { get; set; }
        public DateTime? ECouponGenerationCompleteTime { get; set; }
        public int? ECouponGenerationStatusId { get; set; }
        public DateTime? RewardEffectiveFrom { get; set; }
        public DateTime? RewardEffectiveTo { get; set; }
        public DateTime? RewardPostingFrom { get; set; }
        public DateTime? RewardPostingTo { get; set; }
        public int? ECouponValidationTypeId { get; set; }
        public int? ECouponValidationPeriod { get; set; }
        public DateTime? ECouponValidFrom { get; set; }
        public DateTime? ECouponValidTo { get; set; }
        public string CouponTitleC { get; set; }
        public string CouponTitleE { get; set; }
        public string CouponSubtitleC { get; set; }
        public string CouponSubtitleE { get; set; }
        public string CouponRemarkC { get; set; }
        public string CouponRemarkE { get; set; }
        public string CouponDescriptionC { get; set; }
        public string CouponDescriptionE { get; set; }
        public string Tcc { get; set; }
        public string Tce { get; set; }
        public string MyCouponImageC { get; set; }
        public string MyCouponImageE { get; set; }
        public string ApplicableStore { get; set; }
        public string Prefix { get; set; }
        public bool? QuotaByStore { get; set; }
        public string PassCode { get; set; }

        public virtual YataMotherProduct MotherProduct { get; set; }
        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
        public virtual ICollection<YataECouponMarket> YataECouponMarket { get; set; }
        public virtual ICollection<YataECouponRecord> YataECouponRecord { get; set; }
        public virtual ICollection<YataReedemImage> YataReedemImage { get; set; }
    }
}
