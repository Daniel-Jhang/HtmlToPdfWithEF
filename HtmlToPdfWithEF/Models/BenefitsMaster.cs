using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class BenefitsMaster
    {
        public BenefitsMaster()
        {
            BenefitsCccardKind = new HashSet<BenefitsCccardKind>();
            BenefitsMarket = new HashSet<BenefitsMarket>();
            BenefitsMemberScheme = new HashSet<BenefitsMemberScheme>();
            BenefitsPos = new HashSet<BenefitsPos>();
            BenefitsSalesProduct = new HashSet<BenefitsSalesProduct>();
            BenefitsSalesProductCategroy = new HashSet<BenefitsSalesProductCategroy>();
            BenefitsShop = new HashSet<BenefitsShop>();
            BenefitsShopCategory = new HashSet<BenefitsShopCategory>();
            DummyPointTransactionDetail = new HashSet<DummyPointTransactionDetail>();
            MarketingCostBenefitMaster = new HashSet<MarketingCostBenefitMaster>();
            MemberSchemeType = new HashSet<MemberSchemeType>();
            ShopSharePoint = new HashSet<ShopSharePoint>();
        }

        public int Id { get; set; }
        public string BenefitCode { get; set; }
        public DateTime? CampaignStartDate { get; set; }
        public DateTime? CampaignEndDate { get; set; }
        public int? BenefitTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsDeleted { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public int? Priority { get; set; }
        public double? PointConversationRate { get; set; }
        public decimal? PointEarned { get; set; }
        public int? CeilingTypeId { get; set; }
        public decimal? CeilingPoint { get; set; }
        public int? TimesOfBonusPointsGiven { get; set; }
        public string PointCalculatonType { get; set; }
        public int? MemberSchemeId { get; set; }
        public int? PointEarningTypeId { get; set; }
        public DateTime? PointGivenDate { get; set; }
        public int? CalculationGroupsMasterId { get; set; }
        public int? RoundingMethodId { get; set; }
        public int? PointRoundingDigitId { get; set; }
        public int? CalculationMethodId { get; set; }
        public int? IncentivePeriodId { get; set; }
        public bool? Repeat { get; set; }
        public DateTime? RepeatStartDate { get; set; }
        public DateTime? RepeatEndDate { get; set; }
        public int? RepeatFrequencyId { get; set; }
        public Guid? ActivityId { get; set; }
        public Guid? PointTypeId { get; set; }
        public int? RslId { get; set; }
        public DateTime? RslModifiedTime { get; set; }
        public int? PointRequired { get; set; }
        public int? AmountReward { get; set; }
        public int? BenefitCategoryId { get; set; }
        public int? BenefitDepartmentId { get; set; }
        public bool? Fromtxn { get; set; }
        public Guid? PaymentTypeId { get; set; }
        public Guid? RequireDoubleBenefitId { get; set; }
        public Guid? RewardDoubleBenefitId { get; set; }
        public int? AccumulationId { get; set; }
        public decimal? AccumulateAmount { get; set; }
        public int? MemberSchemeTypeId { get; set; }
        public int? AmountRequired { get; set; }
        public string Repeatweek { get; set; }
        public Guid? ECouponSettingId { get; set; }
        public bool? IsAllowedUsedMoreThenOnePerTransaction { get; set; }

        public virtual Accumulation Accumulation { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual BenefitCategory BenefitCategory { get; set; }
        public virtual BenefitDepartment BenefitDepartment { get; set; }
        public virtual BenefitType BenefitType { get; set; }
        public virtual CalculationGroupsMaster CalculationGroupsMaster { get; set; }
        public virtual CalculationMethod CalculationMethod { get; set; }
        public virtual YataECouponSetting ECouponSetting { get; set; }
        public virtual IncentivePeriod IncentivePeriod { get; set; }
        public virtual MemberScheme MemberScheme { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual PointEarningType PointEarningType { get; set; }
        public virtual RoundingDigit PointRoundingDigit { get; set; }
        public virtual PointType PointType { get; set; }
        public virtual RepeatFrequency RepeatFrequency { get; set; }
        public virtual DoubleBenefit RequireDoubleBenefit { get; set; }
        public virtual DoubleBenefit RewardDoubleBenefit { get; set; }
        public virtual RoundingMethod RoundingMethod { get; set; }
        public virtual ICollection<BenefitsCccardKind> BenefitsCccardKind { get; set; }
        public virtual ICollection<BenefitsMarket> BenefitsMarket { get; set; }
        public virtual ICollection<BenefitsMemberScheme> BenefitsMemberScheme { get; set; }
        public virtual ICollection<BenefitsPos> BenefitsPos { get; set; }
        public virtual ICollection<BenefitsSalesProduct> BenefitsSalesProduct { get; set; }
        public virtual ICollection<BenefitsSalesProductCategroy> BenefitsSalesProductCategroy { get; set; }
        public virtual ICollection<BenefitsShop> BenefitsShop { get; set; }
        public virtual ICollection<BenefitsShopCategory> BenefitsShopCategory { get; set; }
        public virtual ICollection<DummyPointTransactionDetail> DummyPointTransactionDetail { get; set; }
        public virtual ICollection<MarketingCostBenefitMaster> MarketingCostBenefitMaster { get; set; }
        public virtual ICollection<MemberSchemeType> MemberSchemeType { get; set; }
        public virtual ICollection<ShopSharePoint> ShopSharePoint { get; set; }
    }
}
