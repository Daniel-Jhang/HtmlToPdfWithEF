using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataECouponRecord
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Qrcode { get; set; }
        public string ECouponCode { get; set; }
        public DateTime? RedeemDate { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string AvailableMarkets { get; set; }
        public DateTime? UsedDate { get; set; }
        public string UsedInPosid { get; set; }
        public Guid? ECouponSettingId { get; set; }
        public Guid? RedeemProductId { get; set; }
        public Guid? UserDetailId { get; set; }
        public int? EcouponStatusId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? UpdateTimeStamp { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public Guid? RedeemTransactionId { get; set; }
        public int? UsedinMarketId { get; set; }
        public Guid ECouponMotherProductId { get; set; }
        public string ECouponCouponId { get; set; }
        public string ECouponCouponName { get; set; }
        public int? ECouponCouponTypeId { get; set; }
        public int? ECouponRewardIssuingTypeId { get; set; }
        public Guid? ECouponRewardSubTypeId { get; set; }
        public int? ECouponRequierdPoint { get; set; }
        public bool? ECouponRewardGroup { get; set; }
        public bool? ECouponPinToTop { get; set; }
        public bool? ECouponRedeemable { get; set; }
        public bool? ECouponTesting { get; set; }
        public Guid? ECouponTestingMemberSchemeId { get; set; }
        public int? ECouponMemberQuota { get; set; }
        public int? ECouponECouponMaxRedeemQty { get; set; }
        public string ECouponPasscode { get; set; }
        public int? ECouponCouponRedemptionTime { get; set; }
        public Guid? ECouponMarketingListId { get; set; }
        public int? ECouponCouponValue { get; set; }
        public DateTime? ECouponCouponGenerationDateTime { get; set; }
        public DateTime? ECouponCouponGenerationCompleteTime { get; set; }
        public int? ECouponCouponGenerationStatusId { get; set; }
        public DateTime? ECouponRewardEffectiveFrom { get; set; }
        public DateTime? ECouponRewardEffectiveTo { get; set; }
        public DateTime? ECouponRewardPostingFrom { get; set; }
        public DateTime? ECouponRewardPostingTo { get; set; }
        public int? ECouponCouponValidationType { get; set; }
        public int? ECouponCouponValidationPeriod { get; set; }
        public DateTime? ECouponCouponValidFrom { get; set; }
        public DateTime? ECouponCouponValidTo { get; set; }
        public string ECouponApplicableStore { get; set; }
        public string IssueFromSfid { get; set; }
        public Guid? IssueFromPurchaseTxnId { get; set; }
        public string CreatedBySfid { get; set; }
        public string TransactionSfid { get; set; }
        public string LastModifiedBySfid { get; set; }
        public DateTime? MigrationTime { get; set; }

        public virtual YataRewardSubType ECouponRewardSubType { get; set; }
        public virtual YataECouponSetting ECouponSetting { get; set; }
        public virtual YataECouponStatus EcouponStatus { get; set; }
        public virtual PurchaseTransaction IssueFromPurchaseTxn { get; set; }
        public virtual YataRedeemProductMaster RedeemProduct { get; set; }
        public virtual YataRedeemTransaction RedeemTransaction { get; set; }
        public virtual Market UsedinMarket { get; set; }
        public virtual AspNetUserDetail UserDetail { get; set; }
    }
}
