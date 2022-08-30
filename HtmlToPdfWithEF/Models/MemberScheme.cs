using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MemberScheme
    {
        public MemberScheme()
        {
            BenefitsMaster = new HashSet<BenefitsMaster>();
            InversePreviousSchemeLevel = new HashSet<MemberScheme>();
            Member = new HashSet<Member>();
            ParkingDiscount = new HashSet<ParkingDiscount>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int MemberSchemeTypeId { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? VaildFrom { get; set; }
        public DateTime? VaildTo { get; set; }
        public string Description { get; set; }
        public string SchemeLevel { get; set; }
        public decimal? UpgrateAmount { get; set; }
        public decimal? NextLevelSalesAmount { get; set; }
        public decimal? NextLevelRenewalPoints { get; set; }
        public decimal? CurrentSchemeRenewalSalesAmount { get; set; }
        public decimal? CurrentSchemeRenewalPoint { get; set; }
        public decimal? AnnuelFee { get; set; }
        public decimal? PointsRequired { get; set; }
        public decimal? SalesAmountRequired { get; set; }
        public int? PointDecimalPlace { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? ByPointsEarned { get; set; }
        public bool? AnnualFeeRequired { get; set; }
        public bool? BySalesAmountEarned { get; set; }
        public bool? CarryForwardAllowed { get; set; }
        public int? CurrencyId { get; set; }
        public int? MultipleRuleLogicId { get; set; }
        public int? NextSchemeLevelId { get; set; }
        public int? SchemeLevelNumber { get; set; }
        public int? MembershipExpirationId { get; set; }
        public int? MemberExpiryActionId { get; set; }
        public int? PreviousSchemeLevelId { get; set; }
        public decimal? SalesAmountRequiredUpgrade { get; set; }
        public int? SalesAmountCumulativePeriodUpgradeId { get; set; }
        public decimal? SalesAmountRequiredRenewal { get; set; }
        public int? SalesAmountCumulativePeriodRenewalId { get; set; }
        public decimal? VipDiscount { get; set; }
        public int? ParkingHourDiscount { get; set; }
        public bool? IslimitedParkingHour { get; set; }
        public bool? IsAvaliableOnApp { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual MemberExpiryAction MemberExpiryAction { get; set; }
        public virtual MemberSchemeType MemberSchemeType { get; set; }
        public virtual MembershipExpirationAndCumulativePeriod MembershipExpiration { get; set; }
        public virtual MultipleRuleLogic MultipleRuleLogic { get; set; }
        public virtual MemberScheme PreviousSchemeLevel { get; set; }
        public virtual MembershipExpirationAndCumulativePeriod SalesAmountCumulativePeriodRenewal { get; set; }
        public virtual MembershipExpirationAndCumulativePeriod SalesAmountCumulativePeriodUpgrade { get; set; }
        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
        public virtual ICollection<MemberScheme> InversePreviousSchemeLevel { get; set; }
        public virtual ICollection<Member> Member { get; set; }
        public virtual ICollection<ParkingDiscount> ParkingDiscount { get; set; }
    }
}
