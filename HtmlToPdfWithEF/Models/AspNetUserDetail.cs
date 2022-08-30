using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class AspNetUserDetail
    {
        public AspNetUserDetail()
        {
            AspnetUserDetailIdTag = new HashSet<AspnetUserDetailIdTag>();
            AspnetUserDetailMarketingOption = new HashSet<AspnetUserDetailMarketingOption>();
            CarNumberAspnetUserDetail = new HashSet<CarNumberAspnetUserDetail>();
            EcouponRecord = new HashSet<EcouponRecord>();
            EmailVerification = new HashSet<EmailVerification>();
            GamePoint = new HashSet<GamePoint>();
            LackOfKeyValueMemberList = new HashSet<LackOfKeyValueMemberList>();
            LotteryContact = new HashSet<LotteryContact>();
            LotteryContactPurchaseTransaction = new HashSet<LotteryContactPurchaseTransaction>();
            MarketingCostResult = new HashSet<MarketingCostResult>();
            Member = new HashSet<Member>();
            MergeUserRecordFromUserDetail = new HashSet<MergeUserRecord>();
            MergeUserRecordToUserDetail = new HashSet<MergeUserRecord>();
            Parking = new HashSet<Parking>();
            PointTransaction = new HashSet<PointTransaction>();
            PurchaseTransaction = new HashSet<PurchaseTransaction>();
            ReferralCodeUsageFromUserDetail = new HashSet<ReferralCodeUsage>();
            ReferralCodeUsageToUserDetail = new HashSet<ReferralCodeUsage>();
            UserPoint = new HashSet<UserPoint>();
            YataECouponRecord = new HashSet<YataECouponRecord>();
            YataPointAdjustmentHistory = new HashSet<YataPointAdjustmentHistory>();
            YataRedeemTransaction = new HashSet<YataRedeemTransaction>();
            YataUserDeliveryAddress = new HashSet<YataUserDeliveryAddress>();
            YataUserDetailInterest = new HashSet<YataUserDetailInterest>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public int? RegisterLocationMarketId { get; set; }
        public string ChineseName { get; set; }
        public string ChineseLastName { get; set; }
        public string ChineseFullName { get; set; }
        public string EnglishName { get; set; }
        public string EnglishLastName { get; set; }
        public string EnglishFullName { get; set; }
        public string MemberNo { get; set; }
        public string NationalCardId { get; set; }
        public int? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public int? BirthYear { get; set; }
        public int? BirthMonth { get; set; }
        public int? Age { get; set; }
        public int? HousingEstateId { get; set; }
        public int? JobId { get; set; }
        public int? IncomeGroupId { get; set; }
        public bool? IsRejectEmailNotification { get; set; }
        public bool? IsRejectPhoneNotification { get; set; }
        public bool? IsAgreement { get; set; }
        public DateTime? RegistrationDatetime { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public int? Version { get; set; }
        public int? CountryCodeId { get; set; }
        public bool? IsAgreeTermination { get; set; }
        public string ReasonOfTermination { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string MembershipRegisteredBy { get; set; }
        public Guid? CrmId { get; set; }
        public int? AgeGroupId { get; set; }
        public string TextForHousingEstate { get; set; }
        public string BuildingName { get; set; }
        public string Floor { get; set; }
        public string Department { get; set; }
        public bool? IsSend { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? RegionId { get; set; }
        public int? DistrictId { get; set; }
        public bool? IsPhoneVerified { get; set; }
        public bool? IsEmailVerified { get; set; }
        public byte[] RowVersion { get; set; }
        public bool? IsDeleted { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Email { get; set; }
        public bool? EmailOptOut { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string HsvibeId { get; set; }
        public string Appid { get; set; }
        public string DmAddress { get; set; }
        public string DmEmail { get; set; }
        public string DmPostalCode { get; set; }
        public DateTime? MigrationTime { get; set; }
        public string AppAddressLine1 { get; set; }
        public string AppAddressLine2 { get; set; }
        public DateTime? BbbannerExpiryDate { get; set; }
        public bool? CancelMembership { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? MobilOptOut { get; set; }
        public int? FamilyStatusCodeId { get; set; }
        public bool? PostOptOut { get; set; }
        public DateTime? PotentialBbclubExpiryDate { get; set; }
        public int? PreferredLanguageId { get; set; }
        public bool? PushOptOut { get; set; }
        public Guid? ReferredBy { get; set; }
        public string Sfid { get; set; }
        public bool? SmsoptOut { get; set; }
        public int? SalutationId { get; set; }
        public string Xmin { get; set; }
        public DateTime? FirstLoginTime { get; set; }
        public string PromotionCode { get; set; }
        public int? RegisterFromId { get; set; }
        public string UpdateStamp { get; set; }
        public int? StateCodesId { get; set; }
        public Guid? Aadid { get; set; }
        public bool? OptOutAll { get; set; }
        public bool? DmbounceBack { get; set; }
        public Guid? PrimaryCountry { get; set; }
        public int? PrimaryDistrict { get; set; }
        public Guid? PrimaryRegion { get; set; }

        public virtual AgeGroup AgeGroup { get; set; }
        public virtual YataCountryCode CountryCode { get; set; }
        public virtual District District { get; set; }
        public virtual HousingEstate HousingEstate { get; set; }
        public virtual IncomeGroup IncomeGroup { get; set; }
        public virtual Job Job { get; set; }
        public virtual YataCountry PrimaryCountryNavigation { get; set; }
        public virtual District PrimaryDistrictNavigation { get; set; }
        public virtual YataRegion PrimaryRegionNavigation { get; set; }
        public virtual Market RegisterLocationMarket { get; set; }
        public virtual ReferralCode ReferralCode { get; set; }
        public virtual ICollection<AspnetUserDetailIdTag> AspnetUserDetailIdTag { get; set; }
        public virtual ICollection<AspnetUserDetailMarketingOption> AspnetUserDetailMarketingOption { get; set; }
        public virtual ICollection<CarNumberAspnetUserDetail> CarNumberAspnetUserDetail { get; set; }
        public virtual ICollection<EcouponRecord> EcouponRecord { get; set; }
        public virtual ICollection<EmailVerification> EmailVerification { get; set; }
        public virtual ICollection<GamePoint> GamePoint { get; set; }
        public virtual ICollection<LackOfKeyValueMemberList> LackOfKeyValueMemberList { get; set; }
        public virtual ICollection<LotteryContact> LotteryContact { get; set; }
        public virtual ICollection<LotteryContactPurchaseTransaction> LotteryContactPurchaseTransaction { get; set; }
        public virtual ICollection<MarketingCostResult> MarketingCostResult { get; set; }
        public virtual ICollection<Member> Member { get; set; }
        public virtual ICollection<MergeUserRecord> MergeUserRecordFromUserDetail { get; set; }
        public virtual ICollection<MergeUserRecord> MergeUserRecordToUserDetail { get; set; }
        public virtual ICollection<Parking> Parking { get; set; }
        public virtual ICollection<PointTransaction> PointTransaction { get; set; }
        public virtual ICollection<PurchaseTransaction> PurchaseTransaction { get; set; }
        public virtual ICollection<ReferralCodeUsage> ReferralCodeUsageFromUserDetail { get; set; }
        public virtual ICollection<ReferralCodeUsage> ReferralCodeUsageToUserDetail { get; set; }
        public virtual ICollection<UserPoint> UserPoint { get; set; }
        public virtual ICollection<YataECouponRecord> YataECouponRecord { get; set; }
        public virtual ICollection<YataPointAdjustmentHistory> YataPointAdjustmentHistory { get; set; }
        public virtual ICollection<YataRedeemTransaction> YataRedeemTransaction { get; set; }
        public virtual ICollection<YataUserDeliveryAddress> YataUserDeliveryAddress { get; set; }
        public virtual ICollection<YataUserDetailInterest> YataUserDetailInterest { get; set; }
    }
}
