using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Market
    {
        public Market()
        {
            AddValueTransaction = new HashSet<AddValueTransaction>();
            AspNetUserDetail = new HashSet<AspNetUserDetail>();
            BenefitsMarket = new HashSet<BenefitsMarket>();
            DummyPointTransaction = new HashSet<DummyPointTransaction>();
            DummyPurchaseTransaction = new HashSet<DummyPurchaseTransaction>();
            Floor = new HashSet<Floor>();
            HousingEstate = new HashSet<HousingEstate>();
            LotteryMarket = new HashSet<LotteryMarket>();
            MarketingOption = new HashSet<MarketingOption>();
            MemberRegistrationBooth = new HashSet<MemberRegistrationBooth>();
            NavPurchaseOrderRequest = new HashSet<NavPurchaseOrderRequest>();
            NavPurchaseRequest = new HashSet<NavPurchaseRequest>();
            PointTransaction = new HashSet<PointTransaction>();
            PriceList = new HashSet<PriceList>();
            PurchaseTransaction = new HashSet<PurchaseTransaction>();
            ReceieveLocation = new HashSet<ReceieveLocation>();
            RedeemProductStock = new HashSet<RedeemProductStock>();
            RedeemTransactionFromMarket = new HashSet<RedeemTransaction>();
            RedeemTransactionToMarket = new HashSet<RedeemTransaction>();
            SalesTransaction = new HashSet<SalesTransaction>();
            Shop = new HashSet<Shop>();
            YataECouponMarket = new HashSet<YataECouponMarket>();
            YataECouponRecord = new HashSet<YataECouponRecord>();
            YataRedeemProductRedeemedCount = new HashSet<YataRedeemProductRedeemedCount>();
            YataRedeemProductStockQuota = new HashSet<YataRedeemProductStockQuota>();
            YataRedeemTransaction = new HashSet<YataRedeemTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string Store { get; set; }
        public string IpAddress { get; set; }
        public string Code { get; set; }
        public string Telephone { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Sequence { get; set; }
        public int? LocationTypeId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string EnglishAddress { get; set; }
        public string City { get; set; }
        public int? DistrictId { get; set; }
        public string IpAddress2 { get; set; }
        public string IpAddress3 { get; set; }
        public string IpAddress4 { get; set; }
        public string IpAddress5 { get; set; }
        public string Email { get; set; }
        public bool? IsInventorySync { get; set; }
        public int MemberSchemeTypeId { get; set; }
        public int? OctopustypeId { get; set; }
        public Guid? RegionId { get; set; }
        public string Url { get; set; }
        public bool? ThePointExclude { get; set; }

        public virtual LocationType LocationType { get; set; }
        public virtual MemberSchemeType MemberSchemeType { get; set; }
        public virtual OctopusType Octopustype { get; set; }
        public virtual YataRegion Region { get; set; }
        public virtual ICollection<AddValueTransaction> AddValueTransaction { get; set; }
        public virtual ICollection<AspNetUserDetail> AspNetUserDetail { get; set; }
        public virtual ICollection<BenefitsMarket> BenefitsMarket { get; set; }
        public virtual ICollection<DummyPointTransaction> DummyPointTransaction { get; set; }
        public virtual ICollection<DummyPurchaseTransaction> DummyPurchaseTransaction { get; set; }
        public virtual ICollection<Floor> Floor { get; set; }
        public virtual ICollection<HousingEstate> HousingEstate { get; set; }
        public virtual ICollection<LotteryMarket> LotteryMarket { get; set; }
        public virtual ICollection<MarketingOption> MarketingOption { get; set; }
        public virtual ICollection<MemberRegistrationBooth> MemberRegistrationBooth { get; set; }
        public virtual ICollection<NavPurchaseOrderRequest> NavPurchaseOrderRequest { get; set; }
        public virtual ICollection<NavPurchaseRequest> NavPurchaseRequest { get; set; }
        public virtual ICollection<PointTransaction> PointTransaction { get; set; }
        public virtual ICollection<PriceList> PriceList { get; set; }
        public virtual ICollection<PurchaseTransaction> PurchaseTransaction { get; set; }
        public virtual ICollection<ReceieveLocation> ReceieveLocation { get; set; }
        public virtual ICollection<RedeemProductStock> RedeemProductStock { get; set; }
        public virtual ICollection<RedeemTransaction> RedeemTransactionFromMarket { get; set; }
        public virtual ICollection<RedeemTransaction> RedeemTransactionToMarket { get; set; }
        public virtual ICollection<SalesTransaction> SalesTransaction { get; set; }
        public virtual ICollection<Shop> Shop { get; set; }
        public virtual ICollection<YataECouponMarket> YataECouponMarket { get; set; }
        public virtual ICollection<YataECouponRecord> YataECouponRecord { get; set; }
        public virtual ICollection<YataRedeemProductRedeemedCount> YataRedeemProductRedeemedCount { get; set; }
        public virtual ICollection<YataRedeemProductStockQuota> YataRedeemProductStockQuota { get; set; }
        public virtual ICollection<YataRedeemTransaction> YataRedeemTransaction { get; set; }
    }
}
