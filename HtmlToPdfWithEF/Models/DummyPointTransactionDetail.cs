using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class DummyPointTransactionDetail
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? PointTransactionId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Point { get; set; }
        public Guid? ProductId { get; set; }
        public decimal? Quantity { get; set; }
        public Guid? GroupId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public DateTime? BenefitsCampaignStartDate { get; set; }
        public DateTime? BenefitsCampaignEndDate { get; set; }
        public string BenefitsName { get; set; }
        public string BenefitsDescription { get; set; }
        public int? BenefitsBenefitType { get; set; }
        public int? BenefitsPointEarningTypeId { get; set; }
        public int? BenefitsCalculationMethodId { get; set; }
        public string BenefitsMarketCodes { get; set; }
        public string BenefitsShopCategoryCodes { get; set; }
        public string BenefitsShopCodes { get; set; }
        public string BenefitsSalesProductCategory { get; set; }
        public Guid? BenefitsCalculationGroupId { get; set; }
        public int? BenefitsPriority { get; set; }
        public double? BenefitsPointConversationRate { get; set; }
        public decimal? BenefitsPointEarned { get; set; }
        public decimal? BenefitsCeilingPoint { get; set; }
        public int? BenefitsCeilingTypeId { get; set; }
        public int? BenefitsRoundingMethodId { get; set; }
        public int? BenefitsTimesOfBonusPointsGiven { get; set; }
        public int? BenefitsPointRoundingDigitId { get; set; }
        public int? BenefitsIncentivePeriodId { get; set; }
        public DateTime? BenefitsCreateDateTime { get; set; }
        public int BenefitsBenefitsMasterId { get; set; }
        public bool? BenefitsRepeat { get; set; }
        public DateTime? BenefitsRepeatStartDate { get; set; }
        public DateTime? BenefitsRepeatEndDate { get; set; }
        public int? BenefitsRepeatFrequencyId { get; set; }
        public bool? IsExcludeCalculate { get; set; }
        public DateTime? UpdateTimeStamp { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string BenefitsBenefitCode { get; set; }
        public Guid? BenefitsPointTypeId { get; set; }
        public string BenefitsPosCodes { get; set; }
        public int? BenefitsPointRequired { get; set; }
        public int? BenefitsAmountReward { get; set; }
        public int? BenefitsBenefitCategoryId { get; set; }
        public int? BenefitsBenefitDepartmentId { get; set; }
        public DateTime? ExprieDate { get; set; }
        public decimal? InProcessPoint { get; set; }
        public Guid? ActivityId { get; set; }
        public Guid? BenefitsPaymentTypeId { get; set; }
        public int? BenefitsAccumulationId { get; set; }
        public decimal? BenefitsAccumulateAmount { get; set; }
        public string BenefitsShopSharePointCodes { get; set; }
        public string BenefitsCccardKindCodes { get; set; }
        public string BenefitsMemberSchemeCodes { get; set; }
        public string BenefitsRepeatweek { get; set; }
        public int? BenefitsAmountRequired { get; set; }
        public bool? BenefitsIsAllowedUsedMoreThenOnePerTransaction { get; set; }
        public int? BenefitsMemberSchemeTypeId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual BenefitsMaster BenefitsBenefitsMaster { get; set; }
        public virtual MemberSchemeType BenefitsMemberSchemeType { get; set; }
        public virtual DummyCalculationGroups Group { get; set; }
        public virtual DummyPointTransaction PointTransaction { get; set; }
        public virtual YataSalesProductMaster Product { get; set; }
    }
}
