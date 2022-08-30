using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HtmlToPdfWithEF.Models
{
    public partial class PointCalculationEngineContext : DbContext
    {
        public PointCalculationEngineContext()
        {
        }

        public PointCalculationEngineContext(DbContextOptions<PointCalculationEngineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accumulation> Accumulation { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<ActivityPointExpireTime> ActivityPointExpireTime { get; set; }
        public virtual DbSet<AddValueTransaction> AddValueTransaction { get; set; }
        public virtual DbSet<AgeGroup> AgeGroup { get; set; }
        public virtual DbSet<ApproveStatus> ApproveStatus { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AspNetUserDetail> AspNetUserDetail { get; set; }
        public virtual DbSet<AspnetUserDetailIdTag> AspnetUserDetailIdTag { get; set; }
        public virtual DbSet<AspnetUserDetailMarketingOption> AspnetUserDetailMarketingOption { get; set; }
        public virtual DbSet<AzureStatus> AzureStatus { get; set; }
        public virtual DbSet<BasicOrMarket> BasicOrMarket { get; set; }
        public virtual DbSet<BenefitCategory> BenefitCategory { get; set; }
        public virtual DbSet<BenefitDepartment> BenefitDepartment { get; set; }
        public virtual DbSet<BenefitType> BenefitType { get; set; }
        public virtual DbSet<BenefitsCccardKind> BenefitsCccardKind { get; set; }
        public virtual DbSet<BenefitsMarket> BenefitsMarket { get; set; }
        public virtual DbSet<BenefitsMaster> BenefitsMaster { get; set; }
        public virtual DbSet<BenefitsMemberScheme> BenefitsMemberScheme { get; set; }
        public virtual DbSet<BenefitsPos> BenefitsPos { get; set; }
        public virtual DbSet<BenefitsSalesProduct> BenefitsSalesProduct { get; set; }
        public virtual DbSet<BenefitsSalesProductBrand> BenefitsSalesProductBrand { get; set; }
        public virtual DbSet<BenefitsSalesProductCategroy> BenefitsSalesProductCategroy { get; set; }
        public virtual DbSet<BenefitsShop> BenefitsShop { get; set; }
        public virtual DbSet<BenefitsShopCategory> BenefitsShopCategory { get; set; }
        public virtual DbSet<BuChangePointReason> BuChangePointReason { get; set; }
        public virtual DbSet<CalculationGroups> CalculationGroups { get; set; }
        public virtual DbSet<CalculationGroupsMaster> CalculationGroupsMaster { get; set; }
        public virtual DbSet<CalculationMethod> CalculationMethod { get; set; }
        public virtual DbSet<CarNumber> CarNumber { get; set; }
        public virtual DbSet<CarNumberAspnetUserDetail> CarNumberAspnetUserDetail { get; set; }
        public virtual DbSet<CardStatus> CardStatus { get; set; }
        public virtual DbSet<CardType> CardType { get; set; }
        public virtual DbSet<CccardKind> CccardKind { get; set; }
        public virtual DbSet<ChangePointReason> ChangePointReason { get; set; }
        public virtual DbSet<Channel> Channel { get; set; }
        public virtual DbSet<Condition> Condition { get; set; }
        public virtual DbSet<ConfigurationCentral> ConfigurationCentral { get; set; }
        public virtual DbSet<ConfigurationEntries> ConfigurationEntries { get; set; }
        public virtual DbSet<Control> Control { get; set; }
        public virtual DbSet<ControlItem> ControlItem { get; set; }
        public virtual DbSet<ControlStatus> ControlStatus { get; set; }
        public virtual DbSet<ControlType> ControlType { get; set; }
        public virtual DbSet<CrossSellingProduct> CrossSellingProduct { get; set; }
        public virtual DbSet<CrossSellingProductPricingOption> CrossSellingProductPricingOption { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<DailyDetailTransactions> DailyDetailTransactions { get; set; }
        public virtual DbSet<DailyReport> DailyReport { get; set; }
        public virtual DbSet<DateType> DateType { get; set; }
        public virtual DbSet<DeactivateReason> DeactivateReason { get; set; }
        public virtual DbSet<DiscountType> DiscountType { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<DoubleBenefit> DoubleBenefit { get; set; }
        public virtual DbSet<DummyCalculationGroups> DummyCalculationGroups { get; set; }
        public virtual DbSet<DummyPointTransaction> DummyPointTransaction { get; set; }
        public virtual DbSet<DummyPointTransactionDetail> DummyPointTransactionDetail { get; set; }
        public virtual DbSet<DummyPurchaseTransaction> DummyPurchaseTransaction { get; set; }
        public virtual DbSet<DummyPurchaseTransactionDetail> DummyPurchaseTransactionDetail { get; set; }
        public virtual DbSet<DummyPurchaseTransactionLineList> DummyPurchaseTransactionLineList { get; set; }
        public virtual DbSet<DummyPurchaseTransactionPaymentDetail> DummyPurchaseTransactionPaymentDetail { get; set; }
        public virtual DbSet<DummyPurchaseTransactionProductCategory> DummyPurchaseTransactionProductCategory { get; set; }
        public virtual DbSet<ECouponValidationType> ECouponValidationType { get; set; }
        public virtual DbSet<EcouponRecord> EcouponRecord { get; set; }
        public virtual DbSet<EcouponRedemptionPeriod> EcouponRedemptionPeriod { get; set; }
        public virtual DbSet<EcouponSetting> EcouponSetting { get; set; }
        public virtual DbSet<EcouponStock> EcouponStock { get; set; }
        public virtual DbSet<EcouponType> EcouponType { get; set; }
        public virtual DbSet<EcouponUsedPlatform> EcouponUsedPlatform { get; set; }
        public virtual DbSet<EcouponValidationPeriod> EcouponValidationPeriod { get; set; }
        public virtual DbSet<Edmclick> Edmclick { get; set; }
        public virtual DbSet<EmailVerification> EmailVerification { get; set; }
        public virtual DbSet<ExcuteTimeHistory> ExcuteTimeHistory { get; set; }
        public virtual DbSet<ExportStatus> ExportStatus { get; set; }
        public virtual DbSet<Floor> Floor { get; set; }
        public virtual DbSet<Flow> Flow { get; set; }
        public virtual DbSet<FlowControlHist> FlowControlHist { get; set; }
        public virtual DbSet<FlowCycleRecord> FlowCycleRecord { get; set; }
        public virtual DbSet<FlowStatus> FlowStatus { get; set; }
        public virtual DbSet<GamePoint> GamePoint { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<HousingEstate> HousingEstate { get; set; }
        public virtual DbSet<Identity> Identity { get; set; }
        public virtual DbSet<IncentivePeriod> IncentivePeriod { get; set; }
        public virtual DbSet<IncomeGroup> IncomeGroup { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<LackOfKeyValueMemberList> LackOfKeyValueMemberList { get; set; }
        public virtual DbSet<LocationType> LocationType { get; set; }
        public virtual DbSet<LookupTable> LookupTable { get; set; }
        public virtual DbSet<Lottery> Lottery { get; set; }
        public virtual DbSet<LotteryAward> LotteryAward { get; set; }
        public virtual DbSet<LotteryContact> LotteryContact { get; set; }
        public virtual DbSet<LotteryContactPurchaseTransaction> LotteryContactPurchaseTransaction { get; set; }
        public virtual DbSet<LotteryMarket> LotteryMarket { get; set; }
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<MarketingCost> MarketingCost { get; set; }
        public virtual DbSet<MarketingCostBenefitMaster> MarketingCostBenefitMaster { get; set; }
        public virtual DbSet<MarketingCostImage> MarketingCostImage { get; set; }
        public virtual DbSet<MarketingCostRecord> MarketingCostRecord { get; set; }
        public virtual DbSet<MarketingCostReseponseResult> MarketingCostReseponseResult { get; set; }
        public virtual DbSet<MarketingCostResult> MarketingCostResult { get; set; }
        public virtual DbSet<MarketingCostTag> MarketingCostTag { get; set; }
        public virtual DbSet<MarketingCostType> MarketingCostType { get; set; }
        public virtual DbSet<MarketingCostTypeType> MarketingCostTypeType { get; set; }
        public virtual DbSet<MarketingOption> MarketingOption { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberDiscount> MemberDiscount { get; set; }
        public virtual DbSet<MemberExpiryAction> MemberExpiryAction { get; set; }
        public virtual DbSet<MemberRegistrationBooth> MemberRegistrationBooth { get; set; }
        public virtual DbSet<MemberScheme> MemberScheme { get; set; }
        public virtual DbSet<MemberSchemeType> MemberSchemeType { get; set; }
        public virtual DbSet<MemberStatusReason> MemberStatusReason { get; set; }
        public virtual DbSet<MemberTierLog> MemberTierLog { get; set; }
        public virtual DbSet<MembershipExpirationAndCumulativePeriod> MembershipExpirationAndCumulativePeriod { get; set; }
        public virtual DbSet<MergeUserRecord> MergeUserRecord { get; set; }
        public virtual DbSet<MergeUserRecordDetail> MergeUserRecordDetail { get; set; }
        public virtual DbSet<MergeUserStatus> MergeUserStatus { get; set; }
        public virtual DbSet<MobileRegex> MobileRegex { get; set; }
        public virtual DbSet<MobileVerification> MobileVerification { get; set; }
        public virtual DbSet<ModifyPoint> ModifyPoint { get; set; }
        public virtual DbSet<ModifyPointRecord> ModifyPointRecord { get; set; }
        public virtual DbSet<MultipleRuleLogic> MultipleRuleLogic { get; set; }
        public virtual DbSet<NavPurchaseOrderRequest> NavPurchaseOrderRequest { get; set; }
        public virtual DbSet<NavPurchaseRequest> NavPurchaseRequest { get; set; }
        public virtual DbSet<NextControl> NextControl { get; set; }
        public virtual DbSet<OctopusType> OctopusType { get; set; }
        public virtual DbSet<Operator> Operator { get; set; }
        public virtual DbSet<Parking> Parking { get; set; }
        public virtual DbSet<ParkingDiscount> ParkingDiscount { get; set; }
        public virtual DbSet<ParkingPayment> ParkingPayment { get; set; }
        public virtual DbSet<PayKind> PayKind { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<PeriodUnit> PeriodUnit { get; set; }
        public virtual DbSet<PhysicalCardDetail> PhysicalCardDetail { get; set; }
        public virtual DbSet<PhysicalCardDetailCrm> PhysicalCardDetailCrm { get; set; }
        public virtual DbSet<PointEarningType> PointEarningType { get; set; }
        public virtual DbSet<PointTransaction> PointTransaction { get; set; }
        public virtual DbSet<PointTransactionCrmSync> PointTransactionCrmSync { get; set; }
        public virtual DbSet<PointTransactionDetail> PointTransactionDetail { get; set; }
        public virtual DbSet<PointTransactionSourceFrom> PointTransactionSourceFrom { get; set; }
        public virtual DbSet<PointType> PointType { get; set; }
        public virtual DbSet<Pos> Pos { get; set; }
        public virtual DbSet<Preference> Preference { get; set; }
        public virtual DbSet<PriceList> PriceList { get; set; }
        public virtual DbSet<PriceListItem> PriceListItem { get; set; }
        public virtual DbSet<PriceListMarketType> PriceListMarketType { get; set; }
        public virtual DbSet<PriceListType> PriceListType { get; set; }
        public virtual DbSet<PurchaseProductCategory> PurchaseProductCategory { get; set; }
        public virtual DbSet<PurchaseTransaction> PurchaseTransaction { get; set; }
        public virtual DbSet<PurchaseTransactionCrmSync> PurchaseTransactionCrmSync { get; set; }
        public virtual DbSet<PurchaseTransactionDailySubtotal> PurchaseTransactionDailySubtotal { get; set; }
        public virtual DbSet<PurchaseTransactionDetail> PurchaseTransactionDetail { get; set; }
        public virtual DbSet<PurchaseTransactionDetailCrmSync> PurchaseTransactionDetailCrmSync { get; set; }
        public virtual DbSet<PurchaseTransactionLineList> PurchaseTransactionLineList { get; set; }
        public virtual DbSet<PurchaseTransactionPaymentDetail> PurchaseTransactionPaymentDetail { get; set; }
        public virtual DbSet<PurchaseTransactionProductCategory> PurchaseTransactionProductCategory { get; set; }
        public virtual DbSet<PushClick> PushClick { get; set; }
        public virtual DbSet<ReStarter> ReStarter { get; set; }
        public virtual DbSet<ReceieveLocation> ReceieveLocation { get; set; }
        public virtual DbSet<RedeemDiscountMaster> RedeemDiscountMaster { get; set; }
        public virtual DbSet<RedeemPaymentDetail> RedeemPaymentDetail { get; set; }
        public virtual DbSet<RedeemProduct> RedeemProduct { get; set; }
        public virtual DbSet<RedeemProductAssociation> RedeemProductAssociation { get; set; }
        public virtual DbSet<RedeemProductCategory> RedeemProductCategory { get; set; }
        public virtual DbSet<RedeemProductStock> RedeemProductStock { get; set; }
        public virtual DbSet<RedeemProductStructure> RedeemProductStructure { get; set; }
        public virtual DbSet<RedeemTransaction> RedeemTransaction { get; set; }
        public virtual DbSet<RedeemTransactionDetail> RedeemTransactionDetail { get; set; }
        public virtual DbSet<RedeemType> RedeemType { get; set; }
        public virtual DbSet<RedeemtionType> RedeemtionType { get; set; }
        public virtual DbSet<ReferenceTransactionType> ReferenceTransactionType { get; set; }
        public virtual DbSet<ReferrAbout> ReferrAbout { get; set; }
        public virtual DbSet<ReferralCode> ReferralCode { get; set; }
        public virtual DbSet<ReferralCodeUsage> ReferralCodeUsage { get; set; }
        public virtual DbSet<RepeatFrequency> RepeatFrequency { get; set; }
        public virtual DbSet<ReportExpirePointToRevenue> ReportExpirePointToRevenue { get; set; }
        public virtual DbSet<ReportRecord> ReportRecord { get; set; }
        public virtual DbSet<ReportType> ReportType { get; set; }
        public virtual DbSet<RoundingDigit> RoundingDigit { get; set; }
        public virtual DbSet<RoundingMethod> RoundingMethod { get; set; }
        public virtual DbSet<SalesPaymentDetail> SalesPaymentDetail { get; set; }
        public virtual DbSet<SalesTransaction> SalesTransaction { get; set; }
        public virtual DbSet<SalesTransactionDetail> SalesTransactionDetail { get; set; }
        public virtual DbSet<SendResult> SendResult { get; set; }
        public virtual DbSet<SendStatus> SendStatus { get; set; }
        public virtual DbSet<SendType> SendType { get; set; }
        public virtual DbSet<ServiceLock> ServiceLock { get; set; }
        public virtual DbSet<ServiceMaster> ServiceMaster { get; set; }
        public virtual DbSet<ServiceStatus> ServiceStatus { get; set; }
        public virtual DbSet<Sftp> Sftp { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<ShopCategory> ShopCategory { get; set; }
        public virtual DbSet<ShopSharePoint> ShopSharePoint { get; set; }
        public virtual DbSet<ShortUrlRecord> ShortUrlRecord { get; set; }
        public virtual DbSet<SmsisClick> SmsisClick { get; set; }
        public virtual DbSet<SmsstatusCode> SmsstatusCode { get; set; }
        public virtual DbSet<Switch> Switch { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<TagCategory> TagCategory { get; set; }
        public virtual DbSet<TagCustCategory> TagCustCategory { get; set; }
        public virtual DbSet<TagGroup> TagGroup { get; set; }
        public virtual DbSet<TagMonthOrWeek> TagMonthOrWeek { get; set; }
        public virtual DbSet<TagOperator> TagOperator { get; set; }
        public virtual DbSet<TempMarketingTransactionReprot> TempMarketingTransactionReprot { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TestTable> TestTable { get; set; }
        public virtual DbSet<TimeUnit> TimeUnit { get; set; }
        public virtual DbSet<Timer> Timer { get; set; }
        public virtual DbSet<Token> Token { get; set; }
        public virtual DbSet<TransactionMethod> TransactionMethod { get; set; }
        public virtual DbSet<TransactionStatus> TransactionStatus { get; set; }
        public virtual DbSet<TransactionSummaryReport> TransactionSummaryReport { get; set; }
        public virtual DbSet<Trigger> Trigger { get; set; }
        public virtual DbSet<TypeOfField> TypeOfField { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<UnitGroup> UnitGroup { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserPoint> UserPoint { get; set; }
        public virtual DbSet<VContact> VContact { get; set; }
        public virtual DbSet<VMember> VMember { get; set; }
        public virtual DbSet<VipCardRecords> VipCardRecords { get; set; }
        public virtual DbSet<VipCardStatusCode> VipCardStatusCode { get; set; }
        public virtual DbSet<VipCardType> VipCardType { get; set; }
        public virtual DbSet<VipGeneratorProgress> VipGeneratorProgress { get; set; }
        public virtual DbSet<VipGroup> VipGroup { get; set; }
        public virtual DbSet<WaivedType> WaivedType { get; set; }
        public virtual DbSet<YataAspNetUserStateCode> YataAspNetUserStateCode { get; set; }
        public virtual DbSet<YataCeilingType> YataCeilingType { get; set; }
        public virtual DbSet<YataCountry> YataCountry { get; set; }
        public virtual DbSet<YataCountryCode> YataCountryCode { get; set; }
        public virtual DbSet<YataECouponGenerationStatus> YataECouponGenerationStatus { get; set; }
        public virtual DbSet<YataECouponMarket> YataECouponMarket { get; set; }
        public virtual DbSet<YataECouponRecord> YataECouponRecord { get; set; }
        public virtual DbSet<YataECouponSetting> YataECouponSetting { get; set; }
        public virtual DbSet<YataECouponStatus> YataECouponStatus { get; set; }
        public virtual DbSet<YataECouponType> YataECouponType { get; set; }
        public virtual DbSet<YataECouponValidationType> YataECouponValidationType { get; set; }
        public virtual DbSet<YataFamilyStatusCode> YataFamilyStatusCode { get; set; }
        public virtual DbSet<YataFixContent> YataFixContent { get; set; }
        public virtual DbSet<YataFixContentType> YataFixContentType { get; set; }
        public virtual DbSet<YataInterest> YataInterest { get; set; }
        public virtual DbSet<YataLanguage> YataLanguage { get; set; }
        public virtual DbSet<YataList> YataList { get; set; }
        public virtual DbSet<YataMotherProduct> YataMotherProduct { get; set; }
        public virtual DbSet<YataNoBonusPointList> YataNoBonusPointList { get; set; }
        public virtual DbSet<YataPinToTop> YataPinToTop { get; set; }
        public virtual DbSet<YataPointAdjustmentHistory> YataPointAdjustmentHistory { get; set; }
        public virtual DbSet<YataPointHistoryType> YataPointHistoryType { get; set; }
        public virtual DbSet<YataPopUp> YataPopUp { get; set; }
        public virtual DbSet<YataPromotionBanner> YataPromotionBanner { get; set; }
        public virtual DbSet<YataPromotionBannerCategory> YataPromotionBannerCategory { get; set; }
        public virtual DbSet<YataRedeemProductMaster> YataRedeemProductMaster { get; set; }
        public virtual DbSet<YataRedeemProductRedeemedCount> YataRedeemProductRedeemedCount { get; set; }
        public virtual DbSet<YataRedeemProductRedeemedNonStoreQuotaCount> YataRedeemProductRedeemedNonStoreQuotaCount { get; set; }
        public virtual DbSet<YataRedeemProductStockQuota> YataRedeemProductStockQuota { get; set; }
        public virtual DbSet<YataRedeemTransaction> YataRedeemTransaction { get; set; }
        public virtual DbSet<YataReedemImage> YataReedemImage { get; set; }
        public virtual DbSet<YataRegion> YataRegion { get; set; }
        public virtual DbSet<YataRegisterLog> YataRegisterLog { get; set; }
        public virtual DbSet<YataRewardIssuingType> YataRewardIssuingType { get; set; }
        public virtual DbSet<YataRewardSubType> YataRewardSubType { get; set; }
        public virtual DbSet<YataSalesProductBrand> YataSalesProductBrand { get; set; }
        public virtual DbSet<YataSalesProductCategory> YataSalesProductCategory { get; set; }
        public virtual DbSet<YataSalesProductMaster> YataSalesProductMaster { get; set; }
        public virtual DbSet<YataSalutation> YataSalutation { get; set; }
        public virtual DbSet<YataUserDeliveryAddress> YataUserDeliveryAddress { get; set; }
        public virtual DbSet<YataUserDetailInterest> YataUserDetailInterest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=twoffice.cloudnifier.com,20617;Initial Catalog=PointCalculationEngine_YATA;Persist Security Info=False;User ID=dbAdmin;Password=Cloud@500;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=240;Max Pool Size=200");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accumulation>(entity =>
            {
                entity.Property(e => e.EnName).HasMaxLength(50);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Activity")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.EndDay).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RslId).HasMaxLength(50);

                entity.Property(e => e.RslModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ActivityPointExpireTime>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RslModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityPointExpireTime)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_ActivityPointExpireTime_Activity");

                entity.HasOne(d => d.PointType)
                    .WithMany(p => p.ActivityPointExpireTime)
                    .HasForeignKey(d => d.PointTypeId)
                    .HasConstraintName("FK_ActivityPointExpireTime_PointType");
            });

            modelBuilder.Entity<AddValueTransaction>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CscounterUserId)
                    .HasColumnName("CSCounterUserId")
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.AddValueTransaction)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_AddValueTransaction_Market");
            });

            modelBuilder.Entity<AgeGroup>(entity =>
            {
                entity.Property(e => e.AgeGroupEng)
                    .HasColumnName("Age Group - Eng")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<ApproveStatus>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameEn).HasMaxLength(50);
            });

            modelBuilder.Entity<AspNetUserDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.BirthMonth)
                    .HasName("IX_AspNetUserDetail_5");

                entity.HasIndex(e => e.ChineseFullName)
                    .HasName("IX_AspNetUserDetail_3");

                entity.HasIndex(e => e.ChineseName)
                    .HasName("IX_AspNetUserDetail_2");

                entity.HasIndex(e => e.CrmId)
                    .HasName("IX_AspNetUserDetail_8")
                    .IsUnique();

                entity.HasIndex(e => e.EnglishFullName)
                    .HasName("IX_AspNetUserDetail_4");

                entity.HasIndex(e => e.EnglishName)
                    .HasName("IX_AspNetUserDetail_1");

                entity.HasIndex(e => e.NationalCardId)
                    .HasName("IX_AspNetUserDetail_7");

                entity.HasIndex(e => e.PhoneNumber)
                    .HasName("IX_AspNetUserDetail_6");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_AspNetUserDetail")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Aadid).HasColumnName("AADId");

                entity.Property(e => e.Appid)
                    .HasColumnName("APPID")
                    .HasMaxLength(50);

                entity.Property(e => e.BbbannerExpiryDate)
                    .HasColumnName("BBBannerExpiryDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.BuildingName).HasMaxLength(50);

                entity.Property(e => e.ChineseFullName).HasMaxLength(256);

                entity.Property(e => e.ChineseLastName).HasMaxLength(256);

                entity.Property(e => e.ChineseName).HasMaxLength(256);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.DmEmail).HasMaxLength(256);

                entity.Property(e => e.DmPostalCode).HasMaxLength(50);

                entity.Property(e => e.DmbounceBack).HasColumnName("DMBounceBack");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EmailAddress).HasMaxLength(256);

                entity.Property(e => e.EnglishFullName).HasMaxLength(256);

                entity.Property(e => e.EnglishLastName).HasMaxLength(256);

                entity.Property(e => e.EnglishName).HasMaxLength(256);

                entity.Property(e => e.FirstLoginTime).HasColumnType("datetime");

                entity.Property(e => e.Floor).HasMaxLength(50);

                entity.Property(e => e.HsvibeId)
                    .HasColumnName("HsvibeID")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEmailVerified).HasColumnName("isEmailVerified");

                entity.Property(e => e.IsPhoneVerified).HasColumnName("isPhoneVerified");

                entity.Property(e => e.IsSend).HasDefaultValueSql("((0))");

                entity.Property(e => e.MemberNo).HasMaxLength(50);

                entity.Property(e => e.MembershipRegisteredBy).HasMaxLength(256);

                entity.Property(e => e.MigrationTime).HasColumnType("datetime");

                entity.Property(e => e.NationalCardId).HasMaxLength(10);

                entity.Property(e => e.PhoneNumber).HasMaxLength(256);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.PotentialBbclubExpiryDate)
                    .HasColumnName("PotentialBBClubExpiryDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PromotionCode).HasMaxLength(100);

                entity.Property(e => e.ReasonOfTermination).HasMaxLength(2000);

                entity.Property(e => e.RegistrationDatetime).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Sfid).HasMaxLength(50);

                entity.Property(e => e.SmsoptOut).HasColumnName("SMSOptOut");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TerminationDate).HasColumnType("datetime");

                entity.Property(e => e.TextForHousingEstate).HasMaxLength(500);

                entity.Property(e => e.UpdateStamp).HasMaxLength(50);

                entity.Property(e => e.Xmin)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AgeGroup)
                    .WithMany(p => p.AspNetUserDetail)
                    .HasForeignKey(d => d.AgeGroupId)
                    .HasConstraintName("FK_AspNetUserDetail_AgeGroup");

                entity.HasOne(d => d.CountryCode)
                    .WithMany(p => p.AspNetUserDetail)
                    .HasForeignKey(d => d.CountryCodeId)
                    .HasConstraintName("FK_AspNetUserDetail_Yata.CountryCode");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.AspNetUserDetailDistrict)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_AspNetUserDetail_District");

                entity.HasOne(d => d.HousingEstate)
                    .WithMany(p => p.AspNetUserDetail)
                    .HasForeignKey(d => d.HousingEstateId)
                    .HasConstraintName("FK_AspNetUserDetail_HousingEstate");

                entity.HasOne(d => d.IncomeGroup)
                    .WithMany(p => p.AspNetUserDetail)
                    .HasForeignKey(d => d.IncomeGroupId)
                    .HasConstraintName("FK_AspNetUserDetail_IncomeGroup");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.AspNetUserDetail)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_AspNetUserDetail_Job");

                entity.HasOne(d => d.PrimaryCountryNavigation)
                    .WithMany(p => p.AspNetUserDetail)
                    .HasForeignKey(d => d.PrimaryCountry)
                    .HasConstraintName("FK_AspNetUserDetail_Yata.Country");

                entity.HasOne(d => d.PrimaryDistrictNavigation)
                    .WithMany(p => p.AspNetUserDetailPrimaryDistrictNavigation)
                    .HasForeignKey(d => d.PrimaryDistrict)
                    .HasConstraintName("FK_AspNetUserDetail_District1");

                entity.HasOne(d => d.PrimaryRegionNavigation)
                    .WithMany(p => p.AspNetUserDetail)
                    .HasForeignKey(d => d.PrimaryRegion)
                    .HasConstraintName("FK_AspNetUserDetail_Yata.Region");

                entity.HasOne(d => d.RegisterLocationMarket)
                    .WithMany(p => p.AspNetUserDetail)
                    .HasForeignKey(d => d.RegisterLocationMarketId)
                    .HasConstraintName("FK_AspNetUserDetail_Market");
            });

            modelBuilder.Entity<AspnetUserDetailIdTag>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_AspnetUserDetailIdTag")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.AspnetUserDetail)
                    .WithMany(p => p.AspnetUserDetailIdTag)
                    .HasForeignKey(d => d.AspnetUserDetailId)
                    .HasConstraintName("FK_AspnetUserDetailIdTag_AspNetUserDetail");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.AspnetUserDetailIdTag)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_AspnetUserDetailIdTag_Tag");
            });

            modelBuilder.Entity<AspnetUserDetailMarketingOption>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.Id)
                    .HasName("IX_AspnetUserDetailMarketingOption")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.AspnetUserDetail)
                    .WithMany(p => p.AspnetUserDetailMarketingOption)
                    .HasForeignKey(d => d.AspnetUserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AspnetUserDetailMarketingOption_AspNetUserDetail");

                entity.HasOne(d => d.MarketingOption)
                    .WithMany(p => p.AspnetUserDetailMarketingOption)
                    .HasForeignKey(d => d.MarketingOptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AspnetUserDetailMarketingOption_MarketingOption");
            });

            modelBuilder.Entity<AzureStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<BasicOrMarket>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<BenefitCategory>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<BenefitDepartment>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.MemberSchemeType)
                    .WithMany(p => p.BenefitDepartment)
                    .HasForeignKey(d => d.MemberSchemeTypeId)
                    .HasConstraintName("FK_BenefitDepartment_MemberSchemeType");
            });

            modelBuilder.Entity<BenefitType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BenefitsCccardKind>(entity =>
            {
                entity.ToTable("BenefitsCCcardKind");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CccardKindId).HasColumnName("CCcardKindId");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BenefitsMaster)
                    .WithMany(p => p.BenefitsCccardKind)
                    .HasForeignKey(d => d.BenefitsMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsCCcardKind_BenefitsMaster");

                entity.HasOne(d => d.CccardKind)
                    .WithMany(p => p.BenefitsCccardKind)
                    .HasForeignKey(d => d.CccardKindId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsCCcardKind_CCcardKind");
            });

            modelBuilder.Entity<BenefitsMarket>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BenefitsMaster)
                    .WithMany(p => p.BenefitsMarket)
                    .HasForeignKey(d => d.BenefitsMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsMarket_BenefitsMaster");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.BenefitsMarket)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsMarket_Market");
            });

            modelBuilder.Entity<BenefitsMaster>(entity =>
            {
                entity.HasIndex(e => e.Fromtxn);

                entity.Property(e => e.AccumulateAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BenefitCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CampaignEndDate).HasColumnType("datetime");

                entity.Property(e => e.CampaignStartDate).HasColumnType("datetime");

                entity.Property(e => e.CeilingPoint).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CrmId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ECouponSettingId).HasColumnName("eCouponSettingId");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.PointCalculatonType).HasMaxLength(50);

                entity.Property(e => e.PointEarned).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PointGivenDate).HasColumnType("datetime");

                entity.Property(e => e.RepeatEndDate).HasColumnType("datetime");

                entity.Property(e => e.RepeatStartDate).HasColumnType("datetime");

                entity.Property(e => e.Repeatweek).HasMaxLength(50);

                entity.Property(e => e.RslModifiedTime).HasColumnType("datetime");

                entity.HasOne(d => d.Accumulation)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.AccumulationId)
                    .HasConstraintName("FK_BenefitsMaster_Accumulation");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_BenefitsMaster_Activity");

                entity.HasOne(d => d.BenefitCategory)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.BenefitCategoryId)
                    .HasConstraintName("FK_BenefitsMaster_BenefitCategory");

                entity.HasOne(d => d.BenefitDepartment)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.BenefitDepartmentId)
                    .HasConstraintName("FK_BenefitsMaster_BenefitDepartment");

                entity.HasOne(d => d.BenefitType)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.BenefitTypeId)
                    .HasConstraintName("FK_BenefitsMaster_BenefitType");

                entity.HasOne(d => d.CalculationGroupsMaster)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.CalculationGroupsMasterId)
                    .HasConstraintName("FK_BenefitsMaster_CalculationGroupsMaster");

                entity.HasOne(d => d.CalculationMethod)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.CalculationMethodId)
                    .HasConstraintName("FK_BenefitsMaster_CalculationMethod");

                entity.HasOne(d => d.ECouponSetting)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.ECouponSettingId)
                    .HasConstraintName("FK_BenefitsMaster_Yata.eCouponSetting");

                entity.HasOne(d => d.IncentivePeriod)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.IncentivePeriodId)
                    .HasConstraintName("FK_BenefitsMaster_IncentivePeriod");

                entity.HasOne(d => d.MemberScheme)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.MemberSchemeId)
                    .HasConstraintName("FK_BenefitsMaster_MemberScheme");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_BenefitsMaster_PaymentType");

                entity.HasOne(d => d.PointEarningType)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.PointEarningTypeId)
                    .HasConstraintName("FK_BenefitsMaster_PointEarningType");

                entity.HasOne(d => d.PointRoundingDigit)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.PointRoundingDigitId)
                    .HasConstraintName("FK_BenefitsMaster_RoundingDigit");

                entity.HasOne(d => d.PointType)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.PointTypeId)
                    .HasConstraintName("FK_BenefitsMaster_PointType");

                entity.HasOne(d => d.RepeatFrequency)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.RepeatFrequencyId)
                    .HasConstraintName("FK_BenefitsMaster_RepeatFrequency");

                entity.HasOne(d => d.RequireDoubleBenefit)
                    .WithMany(p => p.BenefitsMasterRequireDoubleBenefit)
                    .HasForeignKey(d => d.RequireDoubleBenefitId)
                    .HasConstraintName("FK_BenefitsMaster_DoubleBenefit_Require");

                entity.HasOne(d => d.RewardDoubleBenefit)
                    .WithMany(p => p.BenefitsMasterRewardDoubleBenefit)
                    .HasForeignKey(d => d.RewardDoubleBenefitId)
                    .HasConstraintName("FK_BenefitsMaster_DoubleBenefit_Reward");

                entity.HasOne(d => d.RoundingMethod)
                    .WithMany(p => p.BenefitsMaster)
                    .HasForeignKey(d => d.RoundingMethodId)
                    .HasConstraintName("FK_BenefitsMaster_RoundingMethod");
            });

            modelBuilder.Entity<BenefitsMemberScheme>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BenefitsMaster)
                    .WithMany(p => p.BenefitsMemberScheme)
                    .HasForeignKey(d => d.BenefitsMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsMemberScheme_BenefitsMaster");
            });

            modelBuilder.Entity<BenefitsPos>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BenefitsMaster)
                    .WithMany(p => p.BenefitsPos)
                    .HasForeignKey(d => d.BenefitsMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsPos_BenefitsMaster");
            });

            modelBuilder.Entity<BenefitsSalesProduct>(entity =>
            {
                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.HasOne(d => d.BenefitsMaster)
                    .WithMany(p => p.BenefitsSalesProduct)
                    .HasForeignKey(d => d.BenefitsMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsSalesProduct_BenefitsMaster");

                entity.HasOne(d => d.SalesProductMaster)
                    .WithMany(p => p.BenefitsSalesProduct)
                    .HasForeignKey(d => d.SalesProductMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsSalesProduct_Yata.SalesProductMaster");
            });

            modelBuilder.Entity<BenefitsSalesProductBrand>(entity =>
            {
                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            });

            modelBuilder.Entity<BenefitsSalesProductCategroy>(entity =>
            {
                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BenefitsMaster)
                    .WithMany(p => p.BenefitsSalesProductCategroy)
                    .HasForeignKey(d => d.BenefitsMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsRedeemProductCategroy_BenefitsMaster");
            });

            modelBuilder.Entity<BenefitsShop>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BenefitsMaster)
                    .WithMany(p => p.BenefitsShop)
                    .HasForeignKey(d => d.BenefitsMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsShop_BenefitsMaster");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.BenefitsShop)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsShop_Shop");
            });

            modelBuilder.Entity<BenefitsShopCategory>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BenefitsMaster)
                    .WithMany(p => p.BenefitsShopCategory)
                    .HasForeignKey(d => d.BenefitsMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsShopCategory_BenefitsMaster");

                entity.HasOne(d => d.ShopCategroy)
                    .WithMany(p => p.BenefitsShopCategory)
                    .HasForeignKey(d => d.ShopCategroyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BenefitsShopCategory_ShopCategory");
            });

            modelBuilder.Entity<BuChangePointReason>(entity =>
            {
                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ChangePointReason)
                    .WithMany(p => p.BuChangePointReason)
                    .HasForeignKey(d => d.ChangePointReasonId)
                    .HasConstraintName("FK_BuChangePointReason_ChangePointReason");

                entity.HasOne(d => d.MemberSchemeType)
                    .WithMany(p => p.BuChangePointReason)
                    .HasForeignKey(d => d.MemberSchemeTypeId)
                    .HasConstraintName("FK_BuChangePointReason_MemberSchemeType");
            });

            modelBuilder.Entity<CalculationGroups>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Point).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.RoundingDigit)
                    .WithMany(p => p.CalculationGroups)
                    .HasForeignKey(d => d.RoundingDigitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CalculationGroups_RoundingDigit");

                entity.HasOne(d => d.RoundingMethod)
                    .WithMany(p => p.CalculationGroups)
                    .HasForeignKey(d => d.RoundingMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CalculationGroups_RoundingMethod");
            });

            modelBuilder.Entity<CalculationGroupsMaster>(entity =>
            {
                entity.Property(e => e.CrmId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.RslModifiedTime).HasColumnType("datetime");

                entity.HasOne(d => d.RoundingDigit)
                    .WithMany(p => p.CalculationGroupsMaster)
                    .HasForeignKey(d => d.RoundingDigitId)
                    .HasConstraintName("FK_CalculationGroupsMaster_RoundingDigit");

                entity.HasOne(d => d.RoundingMethod)
                    .WithMany(p => p.CalculationGroupsMaster)
                    .HasForeignKey(d => d.RoundingMethodId)
                    .HasConstraintName("FK_CalculationGroupsMaster_RoundingMethod");
            });

            modelBuilder.Entity<CalculationMethod>(entity =>
            {
                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<CarNumber>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.CarLicenseNumber)
                    .HasName("IX_CarNumber_1")
                    .IsUnique();

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_CarNumber")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CarLicenseNumber).HasMaxLength(10);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CarNumberAspnetUserDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.Sqlid)
                    .HasName("IX_CarNumberAspnetUserDetail")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Sqlid).ValueGeneratedOnAdd();

                entity.HasOne(d => d.AspnetUserDetail)
                    .WithMany(p => p.CarNumberAspnetUserDetail)
                    .HasForeignKey(d => d.AspnetUserDetailId)
                    .HasConstraintName("FK_CarNumberAspnetUserDetail_AspNetUserDetail");

                entity.HasOne(d => d.CarNumber)
                    .WithMany(p => p.CarNumberAspnetUserDetail)
                    .HasForeignKey(d => d.CarNumberId)
                    .HasConstraintName("FK_CarNumberAspnetUserDetail_CarNumber2");

                entity.HasOne(d => d.PrevCarNumberAspnetUserDetail)
                    .WithMany(p => p.InversePrevCarNumberAspnetUserDetail)
                    .HasForeignKey(d => d.PrevCarNumberAspnetUserDetailId)
                    .HasConstraintName("FK_CarNumberAspnetUserDetail_CarNumberAspnetUserDetail");
            });

            modelBuilder.Entity<CardStatus>(entity =>
            {
                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CardType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_CardType")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CccardKind>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("CCcardKind");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_CCcardKind")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ChangePointReason>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Reason).HasMaxLength(50);
            });

            modelBuilder.Entity<Channel>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LeftComparisonEntity).HasMaxLength(50);

                entity.Property(e => e.LeftComparisonEntityField).HasMaxLength(50);

                entity.Property(e => e.LeftComparisonValue).HasMaxLength(50);

                entity.Property(e => e.RightComparisonEntity).HasMaxLength(50);

                entity.Property(e => e.RightComparisonEntityField).HasMaxLength(50);

                entity.Property(e => e.RightComparisonValue).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.NextControl)
                    .WithMany(p => p.Condition)
                    .HasForeignKey(d => d.NextControlId)
                    .HasConstraintName("FK_Condition_NextControl");

                entity.HasOne(d => d.OperatorNavigation)
                    .WithMany(p => p.Condition)
                    .HasForeignKey(d => d.Operator)
                    .HasConstraintName("FK_Condition_Operator");
            });

            modelBuilder.Entity<ConfigurationCentral>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.Settingcode)
                    .HasName("IX_ConfigurationCentral_1")
                    .IsUnique();

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_ConfigurationCentral_2")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Settingcode).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.ValueDateTime).HasColumnType("datetime");

                entity.Property(e => e.ValueDecimal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValueMoney).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValueMoneyBase).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValueText).HasMaxLength(500);
            });

            modelBuilder.Entity<ConfigurationEntries>(entity =>
            {
                entity.HasKey(e => e.ConifgKey);

                entity.Property(e => e.ConifgKey).HasMaxLength(50);

                entity.Property(e => e.ConfigValue).HasMaxLength(300);
            });

            modelBuilder.Entity<Control>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_AccessLocationDetail")
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Control")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.ExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.NewPid).HasColumnName("NewPID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.PositionLeft).HasMaxLength(50);

                entity.Property(e => e.PositionTop).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ControlItem)
                    .WithMany(p => p.Control)
                    .HasForeignKey(d => d.ControlItemId)
                    .HasConstraintName("FK_AccessLocationDetail_ControlItem");

                entity.HasOne(d => d.ControlType)
                    .WithMany(p => p.Control)
                    .HasForeignKey(d => d.ControlTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccessLocationDetail_ControlType");

                entity.HasOne(d => d.Flow)
                    .WithMany(p => p.Control)
                    .HasForeignKey(d => d.FlowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Control_Flow");
            });

            modelBuilder.Entity<ControlItem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ControlType)
                    .WithMany(p => p.ControlItem)
                    .HasForeignKey(d => d.ControlTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ControlItem_ControlType");
            });

            modelBuilder.Entity<ControlStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<ControlType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Shape)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CrossSellingProduct>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_CrossSellingProduct")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyField).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.MainRedeemProduct)
                    .WithMany(p => p.CrossSellingProductMainRedeemProduct)
                    .HasForeignKey(d => d.MainRedeemProductId)
                    .HasConstraintName("FK_CrossSellingProduct_RedeemProduct");

                entity.HasOne(d => d.RelatedRedeemProduct)
                    .WithMany(p => p.CrossSellingProductRelatedRedeemProduct)
                    .HasForeignKey(d => d.RelatedRedeemProductId)
                    .HasConstraintName("FK_CrossSellingProduct_RedeemProduct1");
            });

            modelBuilder.Entity<CrossSellingProductPricingOption>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_CrossSellingProductPricingOption")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyField).HasMaxLength(50);

                entity.Property(e => e.Point).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.CrossSellingProductPricing)
                    .WithMany(p => p.CrossSellingProductPricingOption)
                    .HasForeignKey(d => d.CrossSellingProductPricingId)
                    .HasConstraintName("FK_CrossSellingProductPricingOption_CrossSellingProduct");

                entity.HasOne(d => d.PriceListNavigation)
                    .WithMany(p => p.CrossSellingProductPricingOption)
                    .HasForeignKey(d => d.PriceList)
                    .HasConstraintName("FK_CrossSellingProductPricingOption_PriceList");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.ExChangeRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DailyDetailTransactions>(entity =>
            {
                entity.Property(e => e.AuthNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Batchno)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CommisionAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CredateTime).HasColumnType("datetime");

                entity.Property(e => e.Dcc)
                    .HasColumnName("DCC")
                    .HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Mdr)
                    .IsRequired()
                    .HasColumnName("MDR")
                    .HasMaxLength(50);

                entity.Property(e => e.MerchantNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NetAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReferenceNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TerminalId)
                    .IsRequired()
                    .HasColumnName("TerminalID")
                    .HasMaxLength(50);

                entity.Property(e => e.TraceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.TxAmt).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TxCurrency)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TxDate).HasColumnType("datetime");

                entity.Property(e => e.TxType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DailyReport>(entity =>
            {
                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("date");

                entity.Property(e => e.TransactionDate).HasColumnType("date");
            });

            modelBuilder.Entity<DateType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Sample).HasMaxLength(50);
            });

            modelBuilder.Entity<DeactivateReason>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DiscountType>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.CrmCreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.EnglishName).HasMaxLength(100);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_District_Area");

                entity.HasOne(d => d.RegionNavigation)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.Region)
                    .HasConstraintName("FK_District_Yata.Region");
            });

            modelBuilder.Entity<DoubleBenefit>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_DoubleBenefit")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PointGivenDate).HasColumnType("date");

                entity.Property(e => e.RslId).HasMaxLength(50);

                entity.Property(e => e.RslModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.StatusType)
                    .WithMany(p => p.DoubleBenefit)
                    .HasForeignKey(d => d.StatusTypeId)
                    .HasConstraintName("FK_DoubleBenefit_LookupTable");
            });

            modelBuilder.Entity<DummyCalculationGroups>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Point).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.RoundingDigit)
                    .WithMany(p => p.DummyCalculationGroups)
                    .HasForeignKey(d => d.RoundingDigitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HSVCalculationGroups_RoundingDigit");

                entity.HasOne(d => d.RoundingMethod)
                    .WithMany(p => p.DummyCalculationGroups)
                    .HasForeignKey(d => d.RoundingMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HSVCalculationGroups_RoundingMethod");
            });

            modelBuilder.Entity<DummyPointTransaction>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_HSVPointTransaction")
                    .IsClustered(false);

                entity.HasIndex(e => e.PhoneNumber)
                    .HasName("IX_HSVPointTransaction_1");

                entity.HasIndex(e => e.PointTypeId)
                    .HasName("IX_HSVPointTransaction_5");

                entity.HasIndex(e => e.PurchaseTransactionId)
                    .HasName("IX_HSVPointTransaction_3");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_HSVPointTransaction")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.TransactionDateTime)
                    .HasName("IX_HSVPointTransaction_4");

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_HSVPointTransaction_6");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],switchoffset(getdate(),datepart(tzoffset,(getdate() AT TIME ZONE 'Taipei Standard Time')))))");

                entity.Property(e => e.DisplayPoint).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.RealPoint).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.ApproveStatus)
                    .WithMany(p => p.DummyPointTransaction)
                    .HasForeignKey(d => d.ApproveStatusId)
                    .HasConstraintName("FK_HSVPointTransaction_ApprovalStatus");

                entity.HasOne(d => d.ChangePointReason)
                    .WithMany(p => p.DummyPointTransaction)
                    .HasForeignKey(d => d.ChangePointReasonId)
                    .HasConstraintName("FK_HSVPointTransaction_ChangePointReason");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.DummyPointTransaction)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_HSVPointTransaction_Market");

                entity.HasOne(d => d.MemberDiscount)
                    .WithMany(p => p.DummyPointTransaction)
                    .HasForeignKey(d => d.MemberDiscountId)
                    .HasConstraintName("FK_HSVPointTransaction_MemberDiscount");

                entity.HasOne(d => d.MemberSchemeType)
                    .WithMany(p => p.DummyPointTransaction)
                    .HasForeignKey(d => d.MemberSchemeTypeId)
                    .HasConstraintName("FK_HSVPointTransaction_MemberSchemeType");

                entity.HasOne(d => d.PointType)
                    .WithMany(p => p.DummyPointTransaction)
                    .HasForeignKey(d => d.PointTypeId)
                    .HasConstraintName("FK_HSVPointTransaction_PointType");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.DummyPointTransaction)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .HasConstraintName("FK_DummyPointTransaction_DummyPurchaseTransaction");

                entity.HasOne(d => d.RedeemTransaction)
                    .WithMany(p => p.DummyPointTransaction)
                    .HasForeignKey(d => d.RedeemTransactionId)
                    .HasConstraintName("FK_HSVPointTransaction_RedeemTransaction");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.DummyPointTransaction)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_HSVPointTransaction_Shop");

                entity.HasOne(d => d.SourceFromNavigation)
                    .WithMany(p => p.DummyPointTransaction)
                    .HasForeignKey(d => d.SourceFrom)
                    .HasConstraintName("FK_HSVPointTransaction_PointTransactionSourceFrom");

                entity.HasOne(d => d.StatusType)
                    .WithMany(p => p.DummyPointTransactionStatusType)
                    .HasForeignKey(d => d.StatusTypeId)
                    .HasConstraintName("FK_HSVPointTransaction_LookupTable_Status");

                entity.HasOne(d => d.TransationMethod)
                    .WithMany(p => p.DummyPointTransaction)
                    .HasForeignKey(d => d.TransationMethodId)
                    .HasConstraintName("FK_HSVPointTransaction_TransactionMethod");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DummyPointTransactionType)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_HSVPointTransaction_LookupTable");
            });

            modelBuilder.Entity<DummyPointTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_HSVPointTransactionDetail")
                    .IsClustered(false);

                entity.HasIndex(e => e.BenefitsBenefitsMasterId)
                    .HasName("IX_HSVPointTransactionDetail_BenemasterId");

                entity.HasIndex(e => e.IsExcludeCalculate)
                    .HasName("IX_HSVPointTransactionDetail_IsExcludeCalculate");

                entity.HasIndex(e => e.PointTransactionId)
                    .HasName("IX_HSVPointTransactionDetail_HSVPointTransaction");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_HSVPointTransactionDetail")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.TransactionDateTime)
                    .HasName("IX_HSVPointTransactionDetail_1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BenefitsAccumulateAmount)
                    .HasColumnName("Benefits_AccumulateAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BenefitsAccumulationId).HasColumnName("Benefits_AccumulationId");

                entity.Property(e => e.BenefitsAmountRequired).HasColumnName("Benefits_AmountRequired");

                entity.Property(e => e.BenefitsAmountReward).HasColumnName("Benefits_AmountReward");

                entity.Property(e => e.BenefitsBenefitCategoryId).HasColumnName("Benefits_BenefitCategoryId");

                entity.Property(e => e.BenefitsBenefitCode)
                    .HasColumnName("Benefits_BenefitCode")
                    .HasMaxLength(50);

                entity.Property(e => e.BenefitsBenefitDepartmentId).HasColumnName("Benefits_BenefitDepartmentId");

                entity.Property(e => e.BenefitsBenefitType).HasColumnName("Benefits_BenefitType");

                entity.Property(e => e.BenefitsBenefitsMasterId).HasColumnName("Benefits_BenefitsMasterId");

                entity.Property(e => e.BenefitsCalculationGroupId).HasColumnName("Benefits_CalculationGroupId");

                entity.Property(e => e.BenefitsCalculationMethodId).HasColumnName("Benefits_CalculationMethodId");

                entity.Property(e => e.BenefitsCampaignEndDate)
                    .HasColumnName("Benefits_CampaignEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BenefitsCampaignStartDate)
                    .HasColumnName("Benefits_CampaignStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BenefitsCccardKindCodes)
                    .HasColumnName("Benefits_CCcardKindCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsCeilingPoint)
                    .HasColumnName("Benefits_CeilingPoint")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BenefitsCeilingTypeId).HasColumnName("Benefits_CeilingTypeId");

                entity.Property(e => e.BenefitsCreateDateTime)
                    .HasColumnName("Benefits_CreateDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BenefitsDescription).HasColumnName("Benefits_Description");

                entity.Property(e => e.BenefitsIncentivePeriodId).HasColumnName("Benefits_IncentivePeriodId");

                entity.Property(e => e.BenefitsIsAllowedUsedMoreThenOnePerTransaction).HasColumnName("Benefits_IsAllowedUsedMoreThenOnePerTransaction");

                entity.Property(e => e.BenefitsMarketCodes)
                    .HasColumnName("Benefits_MarketCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsMemberSchemeCodes)
                    .HasColumnName("Benefits_MemberSchemeCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsMemberSchemeTypeId).HasColumnName("Benefits_MemberSchemeTypeId");

                entity.Property(e => e.BenefitsName)
                    .HasColumnName("Benefits_Name")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsPaymentTypeId).HasColumnName("Benefits_PaymentTypeId");

                entity.Property(e => e.BenefitsPointConversationRate).HasColumnName("Benefits_PointConversationRate");

                entity.Property(e => e.BenefitsPointEarned)
                    .HasColumnName("Benefits_PointEarned")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BenefitsPointEarningTypeId).HasColumnName("Benefits_PointEarningTypeId");

                entity.Property(e => e.BenefitsPointRequired).HasColumnName("Benefits_PointRequired");

                entity.Property(e => e.BenefitsPointRoundingDigitId).HasColumnName("Benefits_PointRoundingDigitId");

                entity.Property(e => e.BenefitsPointTypeId).HasColumnName("Benefits_PointTypeId");

                entity.Property(e => e.BenefitsPosCodes)
                    .HasColumnName("Benefits_PosCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsPriority).HasColumnName("Benefits_Priority");

                entity.Property(e => e.BenefitsRepeat).HasColumnName("Benefits_Repeat");

                entity.Property(e => e.BenefitsRepeatEndDate)
                    .HasColumnName("Benefits_RepeatEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BenefitsRepeatFrequencyId).HasColumnName("Benefits_RepeatFrequencyId");

                entity.Property(e => e.BenefitsRepeatStartDate)
                    .HasColumnName("Benefits_RepeatStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BenefitsRepeatweek)
                    .HasColumnName("Benefits_Repeatweek")
                    .HasMaxLength(50);

                entity.Property(e => e.BenefitsRoundingMethodId).HasColumnName("Benefits_RoundingMethodId");

                entity.Property(e => e.BenefitsSalesProductCategory)
                    .HasColumnName("Benefits_SalesProductCategory")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsShopCategoryCodes)
                    .HasColumnName("Benefits_ShopCategoryCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsShopCodes)
                    .HasColumnName("Benefits_ShopCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsShopSharePointCodes)
                    .HasColumnName("Benefits_ShopSharePointCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsTimesOfBonusPointsGiven).HasColumnName("Benefits_TimesOfBonusPointsGiven");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],switchoffset(getdate(),datepart(tzoffset,(getdate() AT TIME ZONE 'Taipei Standard Time')))))");

                entity.Property(e => e.ExprieDate).HasColumnType("datetime");

                entity.Property(e => e.InProcessPoint).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.Point).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.DummyPointTransactionDetail)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_HSVPointTransactionDetail_Activity");

                entity.HasOne(d => d.BenefitsBenefitsMaster)
                    .WithMany(p => p.DummyPointTransactionDetail)
                    .HasForeignKey(d => d.BenefitsBenefitsMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DummyPointTransactionDetail_BenefitsMaster");

                entity.HasOne(d => d.BenefitsMemberSchemeType)
                    .WithMany(p => p.DummyPointTransactionDetail)
                    .HasForeignKey(d => d.BenefitsMemberSchemeTypeId)
                    .HasConstraintName("FK_HSVPointTransactionDetail_MemberSchemeType");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.DummyPointTransactionDetail)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_HSVPointTransactionDetail_HSVCalculationGroups");

                entity.HasOne(d => d.PointTransaction)
                    .WithMany(p => p.DummyPointTransactionDetail)
                    .HasForeignKey(d => d.PointTransactionId)
                    .HasConstraintName("FK_HSVPointTransactionDetail_HSVPointTransaction");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DummyPointTransactionDetail)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_DummyPointTransactionDetail_Yata.SalesProductMaster");
            });

            modelBuilder.Entity<DummyPurchaseTransaction>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_HSVPurchaseTransaction")
                    .IsClustered(false);

                entity.HasIndex(e => e.CreateDateTime)
                    .HasName("IX_HSVPurchaseTransaction_5");

                entity.HasIndex(e => e.InvoiceNumber)
                    .HasName("IX_HSVPurchaseTransaction_2")
                    .IsUnique();

                entity.HasIndex(e => e.IsAlreadyModifiedPoint)
                    .HasName("IX_HSVPurchaseTransaction_6");

                entity.HasIndex(e => e.ModifyPurchaseTransactionId)
                    .HasName("IX_HSVPurchaseTransaction_7");

                entity.HasIndex(e => e.OriginalPurchaseTransactionId)
                    .HasName("IX_DummyPurchaseTransaction");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_HSVPurchaseTransaction_3");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_HSVPurchaseTransaction")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.TransactionDateTime)
                    .HasName("IX_HSVPurchaseTransaction_4");

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_HSVPurchaseTransaction_1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],switchoffset(getdate(),datepart(tzoffset,(getdate() AT TIME ZONE 'Taipei Standard Time')))))");

                entity.Property(e => e.CscounterId)
                    .HasColumnName("CSCounterId")
                    .HasMaxLength(450);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.DiscountTransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.IsSyncToCrm).HasColumnName("IsSyncToCRM");

                entity.Property(e => e.MachineId).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.PosNo).HasMaxLength(20);

                entity.Property(e => e.ReceiptNumber).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.HistoryType)
                    .WithMany(p => p.DummyPurchaseTransaction)
                    .HasForeignKey(d => d.HistoryTypeId)
                    .HasConstraintName("FK_DummyPurchaseTransaction_Yata.HistoryType");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.DummyPurchaseTransaction)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_DummyPurchaseTransaction_Market");

                entity.HasOne(d => d.MemberSchemeType)
                    .WithMany(p => p.DummyPurchaseTransaction)
                    .HasForeignKey(d => d.MemberSchemeTypeId)
                    .HasConstraintName("FK_DummyPurchaseTransaction_MemberSchemeType");

                entity.HasOne(d => d.ModifyPurchaseTransaction)
                    .WithMany(p => p.InverseModifyPurchaseTransaction)
                    .HasForeignKey(d => d.ModifyPurchaseTransactionId)
                    .HasConstraintName("FK_DummyPurchaseTransaction_DummyPurchaseTransaction");

                entity.HasOne(d => d.OriginalPurchaseTransaction)
                    .WithMany(p => p.InverseOriginalPurchaseTransaction)
                    .HasForeignKey(d => d.OriginalPurchaseTransactionId)
                    .HasConstraintName("FK_DummyPurchaseTransaction_DummyPurchaseTransaction1");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.DummyPurchaseTransaction)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DummyPurchaseTransaction_Shop");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DummyPurchaseTransaction)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_DummyPurchaseTransaction_LookupTable");
            });

            modelBuilder.Entity<DummyPurchaseTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_HSVPurchaseTransactionDetail_1")
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_HSVPurchaseTransactionDetail")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.PurchaseTransactionId, e.ItemDescription })
                    .HasName("nci_wi_HSVPurchaseTransactionDetail_60064DD6631376CE64CA093098702B50");

                entity.HasIndex(e => new { e.Id, e.ItemDescription, e.PurchaseProductCategoryId, e.Quantity, e.RowNumber, e.TotalAmount, e.UnitPrice, e.Uom, e.PurchaseTransactionId })
                    .HasName("nci_wi_HSVPurchaseTransactionDetail_59C81AA4E40B60D624DD3485D306749B");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApplyToLine).HasMaxLength(100);

                entity.Property(e => e.CouponCode).HasMaxLength(100);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],switchoffset(getdate(),datepart(tzoffset,(getdate() AT TIME ZONE 'Taipei Standard Time')))))");

                entity.Property(e => e.ItemDescription).HasMaxLength(100);

                entity.Property(e => e.LineNo).HasMaxLength(100);

                entity.Property(e => e.OriginalAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PayCode).HasMaxLength(100);

                entity.Property(e => e.PromotionDesc).HasMaxLength(100);

                entity.Property(e => e.PromotionId).HasMaxLength(100);

                entity.Property(e => e.Psp)
                    .HasColumnName("PSP")
                    .HasMaxLength(100);

                entity.Property(e => e.Qrcode)
                    .HasColumnName("QRCode")
                    .HasMaxLength(100);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RetailType).HasMaxLength(1);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.SubClassId).HasMaxLength(100);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(3);

                entity.Property(e => e.UpdateTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.DummyPurchaseTransactionDetail)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .HasConstraintName("FK_DummyPurchaseTransactionDetail_DummyPurchaseTransaction");

                entity.HasOne(d => d.SalesProductMaster)
                    .WithMany(p => p.DummyPurchaseTransactionDetail)
                    .HasForeignKey(d => d.SalesProductMasterId)
                    .HasConstraintName("FK_DummyPurchaseTransactionDetail_Yata.SalesProductMaster");
            });

            modelBuilder.Entity<DummyPurchaseTransactionLineList>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_DummyPurchaseTransactionLineList")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApplyToLine).HasMaxLength(100);

                entity.Property(e => e.CouponCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.LineNo).HasMaxLength(100);

                entity.Property(e => e.NetAmt).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OriginalAmt).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PayCode).HasMaxLength(100);

                entity.Property(e => e.PromotionDesc).HasMaxLength(100);

                entity.Property(e => e.PromotionId)
                    .HasColumnName("PromotionID")
                    .HasMaxLength(100);

                entity.Property(e => e.Psp)
                    .HasColumnName("PSP")
                    .HasMaxLength(100);

                entity.Property(e => e.Qrcode)
                    .HasColumnName("QRCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RetailType).HasMaxLength(1);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.SubClassid).HasMaxLength(100);

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(50);

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.DummyPurchaseTransactionLineList)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_DummyPurchaseTransactionLineList_PaymentType");

                entity.HasOne(d => d.ProductMaster)
                    .WithMany(p => p.DummyPurchaseTransactionLineList)
                    .HasForeignKey(d => d.ProductMasterId)
                    .HasConstraintName("FK_DummyPurchaseTransactionLineList_Yata.SalesProductMaster");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.DummyPurchaseTransactionLineList)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DummyPurchaseTransactionLineList_DummyPurchaseTransaction");
            });

            modelBuilder.Entity<DummyPurchaseTransactionPaymentDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_DummyPurchaseTransactionPaymentDetail")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ECouponRecordId).HasColumnName("eCouponRecordId");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.DummyPurchaseTransactionPaymentDetail)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DummyPurchaseTransactionPaymentDetail_PaymentType");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.DummyPurchaseTransactionPaymentDetail)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DummyPurchaseTransactionPaymentDetail_DummyPurchaseTransaction");
            });

            modelBuilder.Entity<DummyPurchaseTransactionProductCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PurchaseProductCategory)
                    .WithMany(p => p.DummyPurchaseTransactionProductCategory)
                    .HasForeignKey(d => d.PurchaseProductCategoryId)
                    .HasConstraintName("FK_HSVPurchaseTransactionProductCategory_PurchaseProductCategory");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.DummyPurchaseTransactionProductCategory)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .HasConstraintName("FK_DummyPurchaseTransactionProductCategory_DummyPurchaseTransaction");
            });

            modelBuilder.Entity<ECouponValidationType>(entity =>
            {
                entity.ToTable("eCouponValidationType");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EcouponRecord>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ECouponRecord");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.EcouponCode)
                    .HasColumnName("ECouponCode")
                    .HasMaxLength(100);

                entity.Property(e => e.EcouponSettingId).HasColumnName("ECouponSettingId");

                entity.Property(e => e.EcouponStatusId).HasColumnName("ECouponStatusId");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.N5OutTradeNo)
                    .HasColumnName("N5_out_trade_no")
                    .HasMaxLength(32);

                entity.Property(e => e.OriEcouponRecordId).HasColumnName("OriECouponRecordId");

                entity.Property(e => e.PosId).HasMaxLength(20);

                entity.Property(e => e.QrcodeUrl)
                    .HasColumnName("QRCodeUrl")
                    .HasMaxLength(500);

                entity.Property(e => e.RealPay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RedeemDate).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UsedDate).HasColumnType("datetime");

                entity.Property(e => e.UsedValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.EcouponRecord)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_ECouponRecord_Currency");

                entity.HasOne(d => d.EcouponSetting)
                    .WithMany(p => p.EcouponRecord)
                    .HasForeignKey(d => d.EcouponSettingId)
                    .HasConstraintName("FK_ECouponRecord_ECouponSetting");

                entity.HasOne(d => d.EcouponStatus)
                    .WithMany(p => p.EcouponRecord)
                    .HasForeignKey(d => d.EcouponStatusId)
                    .HasConstraintName("FK_eCouponEntry_ECouponStatus");

                entity.HasOne(d => d.Pos)
                    .WithMany(p => p.EcouponRecord)
                    .HasForeignKey(d => d.PosId)
                    .HasConstraintName("FK_ECouponRecord_N5Profile");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.EcouponRecord)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .HasConstraintName("FK_ECouponRecord_PurchaseTransaction");

                entity.HasOne(d => d.RedeemPlatform)
                    .WithMany(p => p.EcouponRecord)
                    .HasForeignKey(d => d.RedeemPlatformId)
                    .HasConstraintName("FK_ECouponRecord_RedeemtionType");

                entity.HasOne(d => d.RedeemProduct)
                    .WithMany(p => p.EcouponRecord)
                    .HasForeignKey(d => d.RedeemProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_eCouponEntry_RedeemProduct");

                entity.HasOne(d => d.RedeemTransactionDetail)
                    .WithMany(p => p.EcouponRecord)
                    .HasForeignKey(d => d.RedeemTransactionDetailId)
                    .HasConstraintName("FK_ECouponRecord_RedeemTransactionDetail");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.EcouponRecord)
                    .HasForeignKey(d => d.UserDetailId)
                    .HasConstraintName("FK_ECouponRecord_AspNetUserDetail");
            });

            modelBuilder.Entity<EcouponRedemptionPeriod>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EcouponSetting>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("ECouponSetting");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ChineseName).HasMaxLength(50);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.EcouponRedemptionPeriodId).HasColumnName("ECouponRedemptionPeriodId");

                entity.Property(e => e.EcouponTypeId).HasColumnName("ECouponTypeId");

                entity.Property(e => e.EcouponValidationPeriodId).HasColumnName("ECouponValidationPeriodId");

                entity.Property(e => e.EcouponValidationTypeId).HasColumnName("ECouponValidationTypeId");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NavitemCode)
                    .HasColumnName("NAVItemCode")
                    .HasMaxLength(50);

                entity.Property(e => e.RedeemFrom).HasColumnType("datetime");

                entity.Property(e => e.RedeemTo).HasColumnType("datetime");

                entity.Property(e => e.RemainingEcouponQuantity).HasColumnName("RemainingECouponQuantity");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionLowestLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValueCeiling).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.EcouponRedemptionPeriod)
                    .WithMany(p => p.EcouponSetting)
                    .HasForeignKey(d => d.EcouponRedemptionPeriodId)
                    .HasConstraintName("FK_ECouponSetting_EcouponRedemptionPeriod");

                entity.HasOne(d => d.EcouponType)
                    .WithMany(p => p.EcouponSetting)
                    .HasForeignKey(d => d.EcouponTypeId)
                    .HasConstraintName("FK_ECouponSetting_EcouponType");

                entity.HasOne(d => d.EcouponValidationPeriod)
                    .WithMany(p => p.EcouponSetting)
                    .HasForeignKey(d => d.EcouponValidationPeriodId)
                    .HasConstraintName("FK_ECouponSetting_ECouponValidationPeriod");

                entity.HasOne(d => d.EcouponValidationType)
                    .WithMany(p => p.EcouponSetting)
                    .HasForeignKey(d => d.EcouponValidationTypeId)
                    .HasConstraintName("FK_ECouponSetting_eCouponValidationType");

                entity.HasOne(d => d.RedeemProduct)
                    .WithMany(p => p.EcouponSetting)
                    .HasForeignKey(d => d.RedeemProductId)
                    .HasConstraintName("FK_ECouponSetting_RedeemProduct");
            });

            modelBuilder.Entity<EcouponStock>(entity =>
            {
                entity.ToTable("ECouponStock");

                entity.Property(e => e.EcouponSettingId).HasColumnName("ECouponSettingId");

                entity.Property(e => e.RemaininEcouponQuantity).HasColumnName("RemaininECouponQuantity");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EcouponSetting)
                    .WithMany(p => p.EcouponStock)
                    .HasForeignKey(d => d.EcouponSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECouponStock_ECouponSetting");

                entity.HasOne(d => d.RedeemProduct)
                    .WithMany(p => p.EcouponStock)
                    .HasForeignKey(d => d.RedeemProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECouponStock_RedeemProduct");
            });

            modelBuilder.Entity<EcouponType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<EcouponUsedPlatform>(entity =>
            {
                entity.ToTable("ECouponUsedPlatform");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EcouponValidationPeriod>(entity =>
            {
                entity.ToTable("ECouponValidationPeriod");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Edmclick>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("EDMClick");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_EDMClick")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.MarketingCostResult)
                    .WithMany(p => p.Edmclick)
                    .HasForeignKey(d => d.MarketingCostResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDMClick_MarketingCostResult");
            });

            modelBuilder.Entity<EmailVerification>(entity =>
            {
                entity.HasKey(e => e.VerifiedSqlId);

                entity.Property(e => e.VerifiedSqlId).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(256);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.VerifiedTime).HasColumnType("datetime");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.EmailVerification)
                    .HasForeignKey(d => d.UserDetailId)
                    .HasConstraintName("FK_EmailVerification_AspNetUserDetail");
            });

            modelBuilder.Entity<ExcuteTimeHistory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.ExcuteTimeHistory)
                    .HasForeignKey(d => d.ControlId)
                    .HasConstraintName("FK_ExcuteTimeHistory_Control");
            });

            modelBuilder.Entity<ExportStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Floor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Floor")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.Floor)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Floor_Market");
            });

            modelBuilder.Entity<Flow>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Flow");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Flow_1")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.FlowEndTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PublishTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Flow)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Flow_FlowStatus");
            });

            modelBuilder.Entity<FlowControlHist>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_FlowControlHist")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.FlowControlHist)
                    .HasForeignKey(d => d.ControlId)
                    .HasConstraintName("FK_FlowControlHist_Control");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.FlowControlHist)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_FlowControlHist_ControlStatus");
            });

            modelBuilder.Entity<FlowCycleRecord>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CycleRunRecord")
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_FlowCycleRecord")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<FlowStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<GamePoint>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.ExpiryDate)
                    .HasName("IX_GamePoint_6");

                entity.HasIndex(e => e.MemberSchemeTypeId)
                    .HasName("IX_GamePoint_3");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_GamePoint")
                    .IsClustered();

                entity.HasIndex(e => e.Used)
                    .HasName("IX_GamePoint_5");

                entity.HasIndex(e => e.UsedTime)
                    .HasName("IX_GamePoint_4");

                entity.HasIndex(e => e.UserDetailId)
                    .HasName("IX_GamePoint_2");

                entity.HasIndex(e => e.ValidTime)
                    .HasName("IX_GamePoint_1");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.Status).HasComment("NULL:未使用 0:等待中 1:成功");

                entity.Property(e => e.UsedTime).HasColumnType("datetime");

                entity.Property(e => e.ValidTime).HasColumnType("datetime");

                entity.HasOne(d => d.MemberSchemeType)
                    .WithMany(p => p.GamePoint)
                    .HasForeignKey(d => d.MemberSchemeTypeId)
                    .HasConstraintName("FK_GamePoint_MemberSchemeType");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.GamePoint)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .HasConstraintName("FK_GamePoint_PurchaseTransaction");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.GamePoint)
                    .HasForeignKey(d => d.UserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GamePoint_GamePoint");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.GenderNamec).HasMaxLength(10);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<HousingEstate>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.EnglishName).HasMaxLength(256);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.HousingEstate)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_HousingEstate_District");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.HousingEstate)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_HousingEstate_Market");
            });

            modelBuilder.Entity<Identity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<IncentivePeriod>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<IncomeGroup>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.NameEn).HasMaxLength(50);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.NameEn).HasMaxLength(50);
            });

            modelBuilder.Entity<LackOfKeyValueMemberList>(entity =>
            {
                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_LackOfKeyValueMemberList");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.LackOfKeyValueMemberList)
                    .HasForeignKey(d => d.UserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LackOfKeyValueMemberList_AspNetUserDetail");
            });

            modelBuilder.Entity<LocationType>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<LookupTable>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TypeCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Lottery>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Lottery_1")
                    .IsClustered(false);

                entity.HasIndex(e => e.LotteryTime)
                    .HasName("IX_Lottery_1");

                entity.HasIndex(e => e.RegisterEnd)
                    .HasName("IX_Lottery_2");

                entity.HasIndex(e => e.RegisterStart)
                    .HasName("IX_Lottery_3");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Lottery_4")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AwardNote).HasMaxLength(2000);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.GetRewardDeadline).HasColumnType("datetime");

                entity.Property(e => e.GetRewardLocation).HasMaxLength(100);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPeriodicLottery).HasColumnName("isPeriodicLottery");

                entity.Property(e => e.LotteryTime)
                    .HasColumnType("datetime")
                    .HasComment("抽獎日期");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PointRequired).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.RegisterEnd).HasColumnType("datetime");

                entity.Property(e => e.RegisterStart).HasColumnType("datetime");

                entity.Property(e => e.SalesAmountLimit).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<LotteryAward>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_LotteryAward")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Lottery)
                    .WithMany(p => p.LotteryAward)
                    .HasForeignKey(d => d.LotteryId)
                    .HasConstraintName("FK_LotteryAward_Lottery");
            });

            modelBuilder.Entity<LotteryContact>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.AspNetUserDetailId)
                    .HasName("IX_LotteryContact_2");

                entity.HasIndex(e => e.IsEnable)
                    .HasName("IX_LotteryContact_1");

                entity.HasIndex(e => e.LotteryId)
                    .HasName("IX_LotteryContact_3");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_LotteryContact")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AspNetUserDetailId).HasComment("參與會員Id");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LotteryId).HasComment("抽獎活動Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasComment("號碼牌名稱");

                entity.Property(e => e.RemoveTime).HasColumnType("datetime");

                entity.Property(e => e.ReturnTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.WinTime).HasColumnType("datetime");

                entity.HasOne(d => d.AspNetUserDetail)
                    .WithMany(p => p.LotteryContact)
                    .HasForeignKey(d => d.AspNetUserDetailId)
                    .HasConstraintName("FK_LotteryContact_AspNetUserDetail");

                entity.HasOne(d => d.Lottery)
                    .WithMany(p => p.LotteryContact)
                    .HasForeignKey(d => d.LotteryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LotteryContact_Lottery");

                entity.HasOne(d => d.RemoveAward)
                    .WithMany(p => p.LotteryContactRemoveAward)
                    .HasForeignKey(d => d.RemoveAwardId)
                    .HasConstraintName("FK_LotteryContact_LotteryAward1");

                entity.HasOne(d => d.WinningAward)
                    .WithMany(p => p.LotteryContactWinningAward)
                    .HasForeignKey(d => d.WinningAwardId)
                    .HasConstraintName("FK_LotteryContact_LotteryAward");
            });

            modelBuilder.Entity<LotteryContactPurchaseTransaction>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.AspNetUserDetailId)
                    .HasName("IX_LotteryContactPurchaseTransaction_1");

                entity.HasIndex(e => e.IsReturn)
                    .HasName("IX_LotteryContactPurchaseTransaction_3");

                entity.HasIndex(e => e.LotteryContactId)
                    .HasName("IX_LotteryContactPurchaseTransaction_2");

                entity.HasIndex(e => e.PurchaseTransactionId)
                    .HasName("IX_LotteryContactPurchaseTransaction_4");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_LotteryContactPurchaseTransaction")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.TicketAmount)
                    .HasName("IX_LotteryContactPurchaseTransaction_5");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ReceiptNumber).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.SysCreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],switchoffset(getdate(),datepart(tzoffset,(getdate() AT TIME ZONE 'Taipei Standard Time')))))");

                entity.Property(e => e.TicketAmount).HasColumnType("decimal(16, 2)");

                entity.HasOne(d => d.AspNetUserDetail)
                    .WithMany(p => p.LotteryContactPurchaseTransaction)
                    .HasForeignKey(d => d.AspNetUserDetailId)
                    .HasConstraintName("FK_LotteryContactPurchaseTransaction_AspNetUserDetail");

                entity.HasOne(d => d.LotteryContact)
                    .WithMany(p => p.LotteryContactPurchaseTransaction)
                    .HasForeignKey(d => d.LotteryContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LotteryContactPurchaseTransaction_LotteryContact");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.LotteryContactPurchaseTransaction)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .HasConstraintName("FK_LotteryContactPurchaseTransaction_PurchaseTransaction");
            });

            modelBuilder.Entity<LotteryMarket>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.IsDeleted)
                    .HasName("IX_LotteryMarket_2");

                entity.HasIndex(e => e.MarketId)
                    .HasName("IX_LotteryMarket_1");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_LotteryMarket")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Lottery)
                    .WithMany(p => p.LotteryMarket)
                    .HasForeignKey(d => d.LotteryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LotteryMarket_Lottery");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.LotteryMarket)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LotteryMarket_LotteryMarket");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Address3).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EnglishAddress).HasMaxLength(100);

                entity.Property(e => e.EnglishName).HasMaxLength(100);

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.IpAddress2).HasMaxLength(100);

                entity.Property(e => e.IpAddress3).HasMaxLength(100);

                entity.Property(e => e.IpAddress4).HasMaxLength(100);

                entity.Property(e => e.IpAddress5).HasMaxLength(100);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Store).HasMaxLength(100);

                entity.Property(e => e.Telephone).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(100);

                entity.HasOne(d => d.LocationType)
                    .WithMany(p => p.Market)
                    .HasForeignKey(d => d.LocationTypeId)
                    .HasConstraintName("FK_Market_LocationType");

                entity.HasOne(d => d.MemberSchemeType)
                    .WithMany(p => p.Market)
                    .HasForeignKey(d => d.MemberSchemeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Market_MemberSchemeType");

                entity.HasOne(d => d.Octopustype)
                    .WithMany(p => p.Market)
                    .HasForeignKey(d => d.OctopustypeId)
                    .HasConstraintName("FK_Market_OctopusType");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Market)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Market_Yata.Region");
            });

            modelBuilder.Entity<MarketingCost>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_MarketingCost")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.EndDay).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.MarketingCost)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_MarketingCost_Activity");

                entity.HasOne(d => d.BenefitDepartment)
                    .WithMany(p => p.MarketingCost)
                    .HasForeignKey(d => d.BenefitDepartmentId)
                    .HasConstraintName("FK_MarketingCost_BenefitDepartment");

                entity.HasOne(d => d.Flow)
                    .WithMany(p => p.MarketingCost)
                    .HasForeignKey(d => d.FlowId)
                    .HasConstraintName("FK_MarketingCost_Flow");

                entity.HasOne(d => d.MarketingCostType)
                    .WithMany(p => p.MarketingCost)
                    .HasForeignKey(d => d.MarketingCostTypeId)
                    .HasConstraintName("FK_MarketingCost_MarketingCostType");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.MarketingCost)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_MarketingCost_Shop");
            });

            modelBuilder.Entity<MarketingCostBenefitMaster>(entity =>
            {
                entity.HasOne(d => d.BenefitsMaster)
                    .WithMany(p => p.MarketingCostBenefitMaster)
                    .HasForeignKey(d => d.BenefitsMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketingCostBenefitMaster_BenefitsMaster");

                entity.HasOne(d => d.MarketingCost)
                    .WithMany(p => p.MarketingCostBenefitMaster)
                    .HasForeignKey(d => d.MarketingCostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketingCostBenefitMaster_MarketingCost");
            });

            modelBuilder.Entity<MarketingCostImage>(entity =>
            {
                entity.HasKey(e => e.SqlId);

                entity.Property(e => e.SqlId).HasColumnName("SqlID");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InputFileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MarketingCostCrmId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MarketingCostRecord>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Edm_1")
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_MarketingCostRecord")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeepLinkCode).HasMaxLength(250);

                entity.Property(e => e.ExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.Image).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.Subject).HasMaxLength(250);

                entity.Property(e => e.TargetField).HasMaxLength(50);

                entity.HasOne(d => d.SendStatus)
                    .WithMany(p => p.MarketingCostRecord)
                    .HasForeignKey(d => d.SendStatusId)
                    .HasConstraintName("FK_MarketingCostRecord_SendStatus");

                entity.HasOne(d => d.SendType)
                    .WithMany(p => p.MarketingCostRecord)
                    .HasForeignKey(d => d.SendTypeId)
                    .HasConstraintName("FK_MarketingCostRecord_SendType");
            });

            modelBuilder.Entity<MarketingCostReseponseResult>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MarketingCostResult>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.MarketingCostCrmId)
                    .HasName("IX_MarketingCostResult_2");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_MarketingCostResult")
                    .IsClustered();

                entity.HasIndex(e => e.UserDetailId)
                    .HasName("IX_MarketingCostResult_1");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClickTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EdmpostId)
                    .HasColumnName("EDMPostId")
                    .HasMaxLength(50);

                entity.Property(e => e.EdmsuccessId)
                    .HasColumnName("EDMSuccessId")
                    .HasMaxLength(60);

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.MsgId).HasMaxLength(17);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OpenTime).HasColumnType("datetime");

                entity.Property(e => e.PushEven).HasComment("1:到達;2:開啟;3:無效");

                entity.Property(e => e.SmsfinalStatusCodeId).HasColumnName("SMSFinalStatusCodeId");

                entity.Property(e => e.SmsstatusCodeId).HasColumnName("SMSStatusCodeId");

                entity.Property(e => e.SmsstatusFlagStatusCodeId).HasColumnName("SMSStatusFlagStatusCodeId");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.UserDetailCode).HasMaxLength(10);

                entity.HasOne(d => d.MarketingCostRecord)
                    .WithMany(p => p.MarketingCostResult)
                    .HasForeignKey(d => d.MarketingCostRecordId)
                    .HasConstraintName("FK_MarketingCostResult_MarketingCostRecord");

                entity.HasOne(d => d.ReseponseResult)
                    .WithMany(p => p.MarketingCostResult)
                    .HasForeignKey(d => d.ReseponseResultId)
                    .HasConstraintName("FK_MarketingCostResult_MarketingCostReseponseResult");

                entity.HasOne(d => d.SendResult)
                    .WithMany(p => p.MarketingCostResult)
                    .HasForeignKey(d => d.SendResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketingCostResult_SendResult");

                entity.HasOne(d => d.SmsstatusCode)
                    .WithMany(p => p.MarketingCostResultSmsstatusCode)
                    .HasForeignKey(d => d.SmsstatusCodeId)
                    .HasConstraintName("FK_MarketingCostResult_SMSStatusCode");

                entity.HasOne(d => d.SmsstatusFlagStatusCode)
                    .WithMany(p => p.MarketingCostResultSmsstatusFlagStatusCode)
                    .HasForeignKey(d => d.SmsstatusFlagStatusCodeId)
                    .HasConstraintName("FK_MarketingCostResult_SMSStatusCode1");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.MarketingCostResult)
                    .HasForeignKey(d => d.UserDetailId)
                    .HasConstraintName("FK_MarketingCostResult_AspNetUserDetail");
            });

            modelBuilder.Entity<MarketingCostTag>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.MarketingCost)
                    .WithMany(p => p.MarketingCostTag)
                    .HasForeignKey(d => d.MarketingCostId)
                    .HasConstraintName("FK_MarketingCostTag_MarketingCost");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.MarketingCostTag)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_MarketingCostTag_Tag");
            });

            modelBuilder.Entity<MarketingCostType>(entity =>
            {
                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.HasOne(d => d.SendType)
                    .WithMany(p => p.MarketingCostType)
                    .HasForeignKey(d => d.SendTypeId)
                    .HasConstraintName("FK_MarketingCostType_SendType");
            });

            modelBuilder.Entity<MarketingCostTypeType>(entity =>
            {
                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<MarketingOption>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVip).HasColumnName("isVip");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.MarketingOption)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_MarketingOption_Market");

                entity.HasOne(d => d.MarketingCostType)
                    .WithMany(p => p.MarketingOption)
                    .HasForeignKey(d => d.MarketingCostTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketingOption_MarketingCostType");

                entity.HasOne(d => d.Preference)
                    .WithMany(p => p.MarketingOption)
                    .HasForeignKey(d => d.PreferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketingOption_Preference");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasIndex(e => e.CrmId)
                    .HasName("IX_Member_1")
                    .IsUnique();

                entity.HasIndex(e => e.IdentityKey)
                    .HasName("IX_Member")
                    .IsUnique();

                entity.HasIndex(e => new { e.MemberSchemeId, e.IsEnable })
                    .HasName("nci_wi_Member_F49222864EAE9B6810148BB868C9685E");

                entity.HasIndex(e => new { e.IsEnable, e.MemberSchemeId, e.MemberStatusReasonId })
                    .HasName("nci_wi_Member_9B36848A040FF52F77779CB9CF05CACB");

                entity.HasIndex(e => new { e.ActivationDate, e.CrmId, e.CrmVersionNumber, e.DbVersionNumber, e.IsEnable, e.MemberAcquisition, e.MemberSchemeId, e.MembershipId, e.FacebookAccessToken, e.FacebookUserId, e.IsCrmUpdated, e.IsDeleted, e.MemberStatusReasonId, e.UserDetailId })
                    .HasName("nci_wi_Member_10E6BFB11F607B2C0AA1A73093AE56BF");

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.DbVersionNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.FacebookAccessToken).HasMaxLength(256);

                entity.Property(e => e.FacebookUserId).HasMaxLength(256);

                entity.Property(e => e.HomePhone).HasMaxLength(50);

                entity.Property(e => e.IdentityKey).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MembershipId).HasMaxLength(50);

                entity.Property(e => e.MigrationTime).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Pgid).HasColumnName("PGID");

                entity.Property(e => e.ReasonOfTermination).HasMaxLength(2000);

                entity.Property(e => e.RenewalDateTime).HasColumnType("datetime");

                entity.Property(e => e.RenewalFirstTransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.SendMemberToCrm).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubscriptionRefId)
                    .HasColumnName("SubscriptionRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.TerminationDate).HasColumnType("datetime");

                entity.Property(e => e.UpgradeFirstTransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.Xmin)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.MemberAcquisitionNavigation)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.MemberAcquisition)
                    .HasConstraintName("FK_Member_Channel");

                entity.HasOne(d => d.MemberScheme)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.MemberSchemeId)
                    .HasConstraintName("FK_Member_MemberScheme");

                entity.HasOne(d => d.MemberStatusReason)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.MemberStatusReasonId)
                    .HasConstraintName("FK_Member_MemberStatusReason");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.UserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_AspNetUserDetail");
            });

            modelBuilder.Entity<MemberDiscount>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<MemberExpiryAction>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<MemberRegistrationBooth>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.MemberRegistrationBooth)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_MemberRegistrationBooth_Market");
            });

            modelBuilder.Entity<MemberScheme>(entity =>
            {
                entity.Property(e => e.AnnuelFee).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CrmId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.CurrentSchemeRenewalPoint).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CurrentSchemeRenewalSalesAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NextLevelRenewalPoints).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NextLevelSalesAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PointsRequired).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesAmountRequired).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalesAmountRequiredRenewal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalesAmountRequiredUpgrade).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SchemeLevel).HasMaxLength(100);

                entity.Property(e => e.UpgrateAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VaildFrom).HasColumnType("datetime");

                entity.Property(e => e.VaildTo).HasColumnType("datetime");

                entity.Property(e => e.VipDiscount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.MemberScheme)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_MemberScheme_Currency");

                entity.HasOne(d => d.MemberExpiryAction)
                    .WithMany(p => p.MemberScheme)
                    .HasForeignKey(d => d.MemberExpiryActionId)
                    .HasConstraintName("FK_MemberScheme_MemberExpiryAction");

                entity.HasOne(d => d.MemberSchemeType)
                    .WithMany(p => p.MemberScheme)
                    .HasForeignKey(d => d.MemberSchemeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberScheme_MemberSchemeType");

                entity.HasOne(d => d.MembershipExpiration)
                    .WithMany(p => p.MemberSchemeMembershipExpiration)
                    .HasForeignKey(d => d.MembershipExpirationId)
                    .HasConstraintName("FK_MemberScheme_MembershipExpirationAndCumulativePeriod");

                entity.HasOne(d => d.MultipleRuleLogic)
                    .WithMany(p => p.MemberScheme)
                    .HasForeignKey(d => d.MultipleRuleLogicId)
                    .HasConstraintName("FK_MemberScheme_MultipleRuleLogic");

                entity.HasOne(d => d.PreviousSchemeLevel)
                    .WithMany(p => p.InversePreviousSchemeLevel)
                    .HasForeignKey(d => d.PreviousSchemeLevelId)
                    .HasConstraintName("FK_MemberScheme_MemberScheme");

                entity.HasOne(d => d.SalesAmountCumulativePeriodRenewal)
                    .WithMany(p => p.MemberSchemeSalesAmountCumulativePeriodRenewal)
                    .HasForeignKey(d => d.SalesAmountCumulativePeriodRenewalId)
                    .HasConstraintName("FK_MemberScheme_MembershipExpirationAndCumulativePeriod2");

                entity.HasOne(d => d.SalesAmountCumulativePeriodUpgrade)
                    .WithMany(p => p.MemberSchemeSalesAmountCumulativePeriodUpgrade)
                    .HasForeignKey(d => d.SalesAmountCumulativePeriodUpgradeId)
                    .HasConstraintName("FK_MemberScheme_MembershipExpirationAndCumulativePeriod1");
            });

            modelBuilder.Entity<MemberSchemeType>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Crmid)
                    .HasColumnName("CRMId")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.UserNameSuffix).HasMaxLength(3);

                entity.HasOne(d => d.ReturnOfBenefit)
                    .WithMany(p => p.MemberSchemeType)
                    .HasForeignKey(d => d.ReturnOfBenefitId)
                    .HasConstraintName("FK_MemberSchemeType_BenefitsMaster");

                entity.HasOne(d => d.VipGroup)
                    .WithMany(p => p.MemberSchemeType)
                    .HasForeignKey(d => d.VipGroupId)
                    .HasConstraintName("FK_MemberSchemeType_VipGroup");
            });

            modelBuilder.Entity<MemberStatusReason>(entity =>
            {
                entity.Property(e => e.ChineseName).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<MemberTierLog>(entity =>
            {
                entity.HasKey(e => e.SqlId)
                    .HasName("PK__MemberTi__F430862E2207F84C");

                entity.Property(e => e.AccumulatedAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ResetDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpgradeDateTime).HasColumnType("datetime");

                entity.Property(e => e.Vipperiod)
                    .HasColumnName("VIPPeriod")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MembershipExpirationAndCumulativePeriod>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<MergeUserRecord>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_MergeUserRecord")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifyOn).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.FromUserDetail)
                    .WithMany(p => p.MergeUserRecordFromUserDetail)
                    .HasForeignKey(d => d.FromUserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MergeUserRecord_AspNetUserDetail_From");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MergeUserRecord)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_MergeUserRecord_MergeUserStatus");

                entity.HasOne(d => d.ToUserDetail)
                    .WithMany(p => p.MergeUserRecordToUserDetail)
                    .HasForeignKey(d => d.ToUserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MergeUserRecord_AspNetUserDetail_To");
            });

            modelBuilder.Entity<MergeUserRecordDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_MergeUserDetail")
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_MergeUserRecordDetail")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.ModifyOn).HasColumnType("datetime");

                entity.Property(e => e.SourceTableId).HasMaxLength(100);

                entity.Property(e => e.SourceTableName).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MergeUserStatus>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MobileRegex>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ExcludeVerifyRegex).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ValidateRegex)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MobileVerification>(entity =>
            {
                entity.HasKey(e => e.VerifiedSqlId)
                    .IsClustered(false);

                entity.HasIndex(e => e.Id)
                    .HasName("IX_MobileVerification")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.Code, e.PhoneNumber, e.VerifiedSqlId, e.VerifiedTime, e.CountryCode })
                    .HasName("nci_wi_MobileVerification_9287E83D29E71E5C63A758C85D7394D9");

                entity.Property(e => e.VerifiedSqlId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.VerifiedTime).HasColumnType("datetime");

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.MobileVerification)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MobileVerification_MobileRegex");
            });

            modelBuilder.Entity<ModifyPoint>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_ModifyPoint")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ModifyPointRecord>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_ModifyPointRecord")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.NewExpireDateTime).HasColumnType("datetime");

                entity.Property(e => e.SourceExpireDateTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TableName)
                    .HasColumnName("tableName")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ModifyPoint)
                    .WithMany(p => p.ModifyPointRecord)
                    .HasForeignKey(d => d.ModifyPointId)
                    .HasConstraintName("FK_ModifyPointRecord_ModifyPoint");
            });

            modelBuilder.Entity<MultipleRuleLogic>(entity =>
            {
                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<NavPurchaseOrderRequest>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ExpectedReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.NavPurchaseOrderNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseOrderDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptCompleteDate).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.SyncDateTime).HasColumnType("datetime");

                entity.Property(e => e.VendorName).HasMaxLength(50);

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.NavPurchaseOrderRequest)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NavPurchaseOrderRequest_Market");
            });

            modelBuilder.Entity<NavPurchaseRequest>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_NavPurchaseRequest")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.NavPurchaseRequestNo).HasMaxLength(50);

                entity.Property(e => e.PreOrderQrcodeUrl).HasColumnName("PreOrderQRcodeUrl");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.StaffCode).HasMaxLength(50);

                entity.Property(e => e.StaffName).HasMaxLength(50);

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.NavPurchaseRequest)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NavPurchaseRequest_Market");
            });

            modelBuilder.Entity<NextControl>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_NextControl_1")
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PathText)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PreviousControl)
                    .WithMany(p => p.NextControl)
                    .HasForeignKey(d => d.PreviousControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NextControl_Control");
            });

            modelBuilder.Entity<OctopusType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Operator>(entity =>
            {
                entity.HasKey(e => e.SqlId);

                entity.Property(e => e.SqlId).ValueGeneratedNever();

                entity.Property(e => e.OperatorSymbol).HasMaxLength(50);
            });

            modelBuilder.Entity<Parking>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.Parking")
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Parking")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CarNumber).HasMaxLength(15);

                entity.Property(e => e.CardNumber).HasMaxLength(50);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.EntryDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExitTime).HasColumnType("datetime");

                entity.Property(e => e.IntoParkingId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MarketCode).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.CarNumberNavigation)
                    .WithMany(p => p.Parking)
                    .HasForeignKey(d => d.CarNumberId)
                    .HasConstraintName("FK_Parking_CarNumber");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Parking)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Parking_AspNetUserDetail");
            });

            modelBuilder.Entity<ParkingDiscount>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_ParkingDiscount")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.MemberScheme)
                    .WithMany(p => p.ParkingDiscount)
                    .HasForeignKey(d => d.MemberSchemeId)
                    .HasConstraintName("FK_ParkingDiscount_MemberScheme");

                entity.HasOne(d => d.Parking)
                    .WithMany(p => p.ParkingDiscount)
                    .HasForeignKey(d => d.ParkingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParkingDiscount_Parking1");
            });

            modelBuilder.Entity<ParkingPayment>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_dbo.ParkingPayment")
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_ParkingPayment")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.PaymentDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReciptNumber).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Parking)
                    .WithMany(p => p.ParkingPayment)
                    .HasForeignKey(d => d.ParkingId)
                    .HasConstraintName("FK_ParkingPayment_Parking");

                entity.HasOne(d => d.PointTransaction)
                    .WithMany(p => p.ParkingPayment)
                    .HasForeignKey(d => d.PointTransactionId)
                    .HasConstraintName("FK_ParkingPayment_PointTransaction");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.ParkingPayment)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .HasConstraintName("FK_ParkingPayment_PurchaseTransaction");
            });

            modelBuilder.Entity<PayKind>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PaymentType")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PayKind)
                    .WithMany(p => p.PaymentType)
                    .HasForeignKey(d => d.PayKindId)
                    .HasConstraintName("FK_PaymentType_PayKind");
            });

            modelBuilder.Entity<PeriodUnit>(entity =>
            {
                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<PhysicalCardDetail>(entity =>
            {
                entity.HasIndex(e => e.CardNumber)
                    .HasName("IX_PhysicalCardDetail")
                    .IsUnique();

                entity.HasIndex(e => e.CrmId)
                    .HasName("IX_PhysicalCardDetail_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ActivatedInMarketId, e.ActivatedOn, e.CardStatusId, e.MemberId })
                    .HasName("nci_wi_PhysicalCardDetail_608682B0591380EB789E4C5ACF27E943");

                entity.HasIndex(e => new { e.ActivatedInMarketId, e.ActivatedOn, e.CardNumber, e.CardStatusId, e.DeactivatedInMarketId, e.DeactivatedOn, e.MemberId })
                    .HasName("nci_wi_PhysicalCardDetail_CB89A9E755198C420C98BDC4DFAD63A2");

                entity.Property(e => e.ActivatedBy).HasMaxLength(50);

                entity.Property(e => e.ActivatedOn).HasColumnType("datetime");

                entity.Property(e => e.CardNumber).HasMaxLength(100);

                entity.Property(e => e.CccardKindId).HasColumnName("CCcardKindId");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.DbVersionNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeactivatedBy).HasMaxLength(50);

                entity.Property(e => e.DeactivatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MigrationTime).HasColumnType("datetime");

                entity.HasOne(d => d.CardStatus)
                    .WithMany(p => p.PhysicalCardDetail)
                    .HasForeignKey(d => d.CardStatusId)
                    .HasConstraintName("FK_PhysicalCardDetail_CardStatus");

                entity.HasOne(d => d.CardType)
                    .WithMany(p => p.PhysicalCardDetail)
                    .HasForeignKey(d => d.CardTypeId)
                    .HasConstraintName("FK_PhysicalCardDetail_CardType");

                entity.HasOne(d => d.CccardKind)
                    .WithMany(p => p.PhysicalCardDetail)
                    .HasForeignKey(d => d.CccardKindId)
                    .HasConstraintName("FK_PhysicalCardDetail_CCcardKind");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.PhysicalCardDetail)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_PhysicalCardDetail_Member");

                entity.HasOne(d => d.MemberSchemeType)
                    .WithMany(p => p.PhysicalCardDetail)
                    .HasForeignKey(d => d.MemberSchemeTypeId)
                    .HasConstraintName("FK_PhysicalCardDetail_MemberSchemeType");
            });

            modelBuilder.Entity<PhysicalCardDetailCrm>(entity =>
            {
                entity.Property(e => e.CardNumber).HasMaxLength(100);

                entity.Property(e => e.CrmId).HasMaxLength(50);
            });

            modelBuilder.Entity<PointEarningType>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<PointTransaction>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.PhysicalCardNumber)
                    .HasName("IX_PointTransaction_1");

                entity.HasIndex(e => e.PurchaseTransactionId)
                    .HasName("IX_PointTransaction_3");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PointTransaction")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.TransactionDateTime)
                    .HasName("IX_PointTransaction_4");

                entity.HasIndex(e => e.UserDetailId)
                    .HasName("IX_PointTransaction_2");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayPoint).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.MigrationTime).HasColumnType("datetime");

                entity.Property(e => e.PhysicalCardNumber).HasMaxLength(100);

                entity.Property(e => e.RealPoint).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.ApproveStatus)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.ApproveStatusId)
                    .HasConstraintName("FK_PointTransaction_ApprovalStatus");

                entity.HasOne(d => d.ChangePointReason)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.ChangePointReasonId)
                    .HasConstraintName("FK_PointTransaction_ChangePointReason");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_PointTransaction_Market");

                entity.HasOne(d => d.MemberDiscount)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.MemberDiscountId)
                    .HasConstraintName("FK_PointTransaction_MemberDiscount");

                entity.HasOne(d => d.MemberSchemeType)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.MemberSchemeTypeId)
                    .HasConstraintName("FK_PointTransaction_MemberSchemeType");

                entity.HasOne(d => d.PointType)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.PointTypeId)
                    .HasConstraintName("FK_PointTransaction_PointType");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .HasConstraintName("FK_PointTransaction_PurchaseTransaction");

                entity.HasOne(d => d.RedeemTransaction)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.RedeemTransactionId)
                    .HasConstraintName("FK_PointTransaction_RedeemTransaction");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_PointTransaction_Shop");

                entity.HasOne(d => d.SourceFromNavigation)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.SourceFrom)
                    .HasConstraintName("FK_PointTransaction_PointTransactionSourceFrom");

                entity.HasOne(d => d.StatusType)
                    .WithMany(p => p.PointTransactionStatusType)
                    .HasForeignKey(d => d.StatusTypeId)
                    .HasConstraintName("FK_PointTransaction_LookupTable_Status");

                entity.HasOne(d => d.TransationMethod)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.TransationMethodId)
                    .HasConstraintName("FK_PointTransaction_TransactionMethod");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PointTransactionType)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_PointTransaction_LookupTable");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.PointTransaction)
                    .HasForeignKey(d => d.UserDetailId)
                    .HasConstraintName("FK_PointTransaction_AspNetUserDetail");
            });

            modelBuilder.Entity<PointTransactionCrmSync>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CrmUpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.PointTransaction)
                    .WithMany(p => p.PointTransactionCrmSync)
                    .HasForeignKey(d => d.PointTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PointTransactionCrmSync_PointTransaction");
            });

            modelBuilder.Entity<PointTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.BenefitsBenefitsMasterId)
                    .HasName("IX_PointTransactionDetail_BenemasterId");

                entity.HasIndex(e => e.IsExcludeCalculate);

                entity.HasIndex(e => e.PointTransactionId)
                    .HasName("IX_PointTransactionDetail_PointTransaction");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PointTransactionDetail")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.TransactionDateTime)
                    .HasName("IX_PointTransactionDetail_1");

                entity.HasIndex(e => e.UserDetailId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BenefitsAccumulateAmount)
                    .HasColumnName("Benefits_AccumulateAmount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BenefitsAccumulationId).HasColumnName("Benefits_AccumulationId");

                entity.Property(e => e.BenefitsAmountRequired).HasColumnName("Benefits_AmountRequired");

                entity.Property(e => e.BenefitsAmountReward).HasColumnName("Benefits_AmountReward");

                entity.Property(e => e.BenefitsBenefitCategoryId).HasColumnName("Benefits_BenefitCategoryId");

                entity.Property(e => e.BenefitsBenefitCode)
                    .HasColumnName("Benefits_BenefitCode")
                    .HasMaxLength(50);

                entity.Property(e => e.BenefitsBenefitDepartmentId).HasColumnName("Benefits_BenefitDepartmentId");

                entity.Property(e => e.BenefitsBenefitType).HasColumnName("Benefits_BenefitType");

                entity.Property(e => e.BenefitsBenefitsMasterId).HasColumnName("Benefits_BenefitsMasterId");

                entity.Property(e => e.BenefitsCalculationGroupId).HasColumnName("Benefits_CalculationGroupId");

                entity.Property(e => e.BenefitsCalculationMethodId).HasColumnName("Benefits_CalculationMethodId");

                entity.Property(e => e.BenefitsCampaignEndDate)
                    .HasColumnName("Benefits_CampaignEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BenefitsCampaignStartDate)
                    .HasColumnName("Benefits_CampaignStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BenefitsCccardKindCodes)
                    .HasColumnName("Benefits_CCcardKindCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsCeilingPoint)
                    .HasColumnName("Benefits_CeilingPoint")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BenefitsCeilingTypeId).HasColumnName("Benefits_CeilingTypeId");

                entity.Property(e => e.BenefitsCreateDateTime)
                    .HasColumnName("Benefits_CreateDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.BenefitsDescription).HasColumnName("Benefits_Description");

                entity.Property(e => e.BenefitsEarningTypeId).HasColumnName("Benefits_EarningTypeId");

                entity.Property(e => e.BenefitsIncentivePeriodId).HasColumnName("Benefits_IncentivePeriodId");

                entity.Property(e => e.BenefitsIsAllowedUsedMoreThenOnePerTransaction).HasColumnName("Benefits_IsAllowedUsedMoreThenOnePerTransaction");

                entity.Property(e => e.BenefitsMarketCodes).HasColumnName("Benefits_MarketCodes");

                entity.Property(e => e.BenefitsMemberSchemeCodes)
                    .HasColumnName("Benefits_MemberSchemeCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsMemberSchemeTypeId).HasColumnName("Benefits_MemberSchemeTypeId");

                entity.Property(e => e.BenefitsName)
                    .HasColumnName("Benefits_Name")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsPaymentTypeId).HasColumnName("Benefits_PaymentTypeId");

                entity.Property(e => e.BenefitsPointConversationRate).HasColumnName("Benefits_PointConversationRate");

                entity.Property(e => e.BenefitsPointEarned)
                    .HasColumnName("Benefits_PointEarned")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BenefitsPointEarningTypeId).HasColumnName("Benefits_PointEarningTypeId");

                entity.Property(e => e.BenefitsPointRequired).HasColumnName("Benefits_PointRequired");

                entity.Property(e => e.BenefitsPointRoundingDigitId).HasColumnName("Benefits_PointRoundingDigitId");

                entity.Property(e => e.BenefitsPointTypeId).HasColumnName("Benefits_PointTypeId");

                entity.Property(e => e.BenefitsPosCodes)
                    .HasColumnName("Benefits_PosCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsPriority).HasColumnName("Benefits_Priority");

                entity.Property(e => e.BenefitsRepeat).HasColumnName("Benefits_Repeat");

                entity.Property(e => e.BenefitsRepeatEndDate)
                    .HasColumnName("Benefits_RepeatEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BenefitsRepeatFrequencyId).HasColumnName("Benefits_RepeatFrequencyId");

                entity.Property(e => e.BenefitsRepeatStartDate)
                    .HasColumnName("Benefits_RepeatStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BenefitsRepeatweek)
                    .HasColumnName("Benefits_Repeatweek")
                    .HasMaxLength(50);

                entity.Property(e => e.BenefitsRoundingMethodId).HasColumnName("Benefits_RoundingMethodId");

                entity.Property(e => e.BenefitsSalesProductCategory).HasColumnName("Benefits_SalesProductCategory");

                entity.Property(e => e.BenefitsShopCategoryCodes)
                    .HasColumnName("Benefits_ShopCategoryCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsShopCodes).HasColumnName("Benefits_ShopCodes");

                entity.Property(e => e.BenefitsShopSharePointCodes)
                    .HasColumnName("Benefits_ShopSharePointCodes")
                    .HasMaxLength(256);

                entity.Property(e => e.BenefitsTimesOfBonusPointsGiven).HasColumnName("Benefits_TimesOfBonusPointsGiven");

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExprieDate).HasColumnType("datetime");

                entity.Property(e => e.InProcessPoint).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MigrationTime).HasColumnType("datetime");

                entity.Property(e => e.Point).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.PointTransactionDetail)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_PointTransactionDetail_Activity");

                entity.HasOne(d => d.BenefitsMemberSchemeType)
                    .WithMany(p => p.PointTransactionDetail)
                    .HasForeignKey(d => d.BenefitsMemberSchemeTypeId)
                    .HasConstraintName("FK_PointTransactionDetail_MemberSchemeType");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.PointTransactionDetail)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_PointTransactionDetail_CalculationGroups");

                entity.HasOne(d => d.PointTransaction)
                    .WithMany(p => p.PointTransactionDetail)
                    .HasForeignKey(d => d.PointTransactionId)
                    .HasConstraintName("FK_PointTransactionDetail_PointTransaction");
            });

            modelBuilder.Entity<PointTransactionSourceFrom>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PointType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PointType")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Pos>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_N5Profile")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.CrmId, e.CrmModifiedTime, e.Id, e.IsDeleted, e.ShopId, e.PosId })
                    .HasName("nci_wi_N5Profile_AA0C2FDF46EEA334A0EFE06AD799D8F5");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BankAccountName).HasMaxLength(50);

                entity.Property(e => e.BankAccountNo).HasMaxLength(50);

                entity.Property(e => e.BankBranchNo).HasMaxLength(50);

                entity.Property(e => e.BankCode).HasMaxLength(50);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantNo).HasMaxLength(50);

                entity.Property(e => e.MigrationTime).HasColumnType("datetime");

                entity.Property(e => e.PosId).HasMaxLength(20);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Pos)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_N5Profile_Shop");
            });

            modelBuilder.Entity<Preference>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PriceList>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PriceList")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.BasicOrMarketNavigation)
                    .WithMany(p => p.PriceList)
                    .HasForeignKey(d => d.BasicOrMarket)
                    .HasConstraintName("FK_PriceList_BasicOrMarket");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.PriceList)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_PriceList_Currency");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.PriceList)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_PriceList_Market");

                entity.HasOne(d => d.PriceListType)
                    .WithMany(p => p.PriceList)
                    .HasForeignKey(d => d.PriceListTypeId)
                    .HasConstraintName("FK_PriceList_PriceListType");
            });

            modelBuilder.Entity<PriceListItem>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PriceListItem")
                    .IsClustered();

                entity.HasIndex(e => new { e.CreateOn, e.CrmId, e.CrmModifiedTime, e.Id, e.IsDeleted, e.KeyField, e.OriginalPoint, e.OriginalPrice, e.Point, e.Price, e.UnitCrmId, e.UnitName, e.UnitId, e.PriceListId, e.RedeemProductId })
                    .HasName("nci_wi_PriceListItem_C83102A39C5DE1E4F4550852C0A36C5A");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyField).HasMaxLength(100);

                entity.Property(e => e.OriginalPoint).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Point).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.UnitCrmId)
                    .HasColumnName("Unit_CrmId")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitName)
                    .HasColumnName("Unit_Name")
                    .HasMaxLength(256);

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.PriceListItem)
                    .HasForeignKey(d => d.PriceListId)
                    .HasConstraintName("FK_PriceListItem_PriceList");

                entity.HasOne(d => d.RedeemProduct)
                    .WithMany(p => p.PriceListItem)
                    .HasForeignKey(d => d.RedeemProductId)
                    .HasConstraintName("FK_PriceListItem_RedeemProduct");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PriceListItem)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_PriceListItem_Unit");
            });

            modelBuilder.Entity<PriceListMarketType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PriceListType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PurchaseProductCategory>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<PurchaseTransaction>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.CreateDateTime)
                    .HasName("IX_PurchaseTransaction_5");

                entity.HasIndex(e => e.InvoiceNumber)
                    .HasName("IX_PurchaseTransaction_2")
                    .IsUnique();

                entity.HasIndex(e => e.IsAlreadyModifiedPoint)
                    .HasName("IX_PurchaseTransaction_6");

                entity.HasIndex(e => e.ModifyPurchaseTransactionId)
                    .HasName("IX_PurchaseTransaction_7");

                entity.HasIndex(e => e.OriginalPurchaseTransactionId)
                    .HasName("IX_PurchaseTransaction_8");

                entity.HasIndex(e => e.ShopId)
                    .HasName("IX_PurchaseTransaction_3");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PurchaseTransaction")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.TransactionDateTime)
                    .HasName("IX_PurchaseTransaction_4");

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_PurchaseTransaction_1");

                entity.HasIndex(e => new { e.CscounterId, e.Currency, e.Id, e.InvoiceNumber, e.MachineId, e.MarketId, e.MembershipCardId, e.ModifyPurchaseTransactionId, e.PosNo, e.PhysicalCardNumber, e.TransactionAmount, e.TypeId, e.IsAlreadyModifiedPoint, e.IsSyncToCrm, e.UserDetailId, e.TransactionDateTime })
                    .HasName("nci_wi_PurchaseTransaction_6BC8FFB40DA0BBF7281DEA6C89067F03");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CscounterId).HasColumnName("CSCounterId");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.DiscountTransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.IsSyncToCrm).HasColumnName("IsSyncToCRM");

                entity.Property(e => e.MachineId).HasMaxLength(50);

                entity.Property(e => e.MembershipCardId).HasMaxLength(100);

                entity.Property(e => e.MigrationTime).HasColumnType("datetime");

                entity.Property(e => e.PhysicalCardNumber).HasMaxLength(100);

                entity.Property(e => e.PosNo).HasMaxLength(20);

                entity.Property(e => e.ReceiptNumber).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.HistoryType)
                    .WithMany(p => p.PurchaseTransaction)
                    .HasForeignKey(d => d.HistoryTypeId)
                    .HasConstraintName("FK_PurchaseTransaction_Yata.HistoryType");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.PurchaseTransaction)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_PurchaseTransaction_Market");

                entity.HasOne(d => d.MemberSchemeType)
                    .WithMany(p => p.PurchaseTransaction)
                    .HasForeignKey(d => d.MemberSchemeTypeId)
                    .HasConstraintName("FK_PurchaseTransaction_MemberSchemeType");

                entity.HasOne(d => d.ModifyPurchaseTransaction)
                    .WithMany(p => p.InverseModifyPurchaseTransaction)
                    .HasForeignKey(d => d.ModifyPurchaseTransactionId)
                    .HasConstraintName("FK_PurchaseTransaction_PurchaseTransaction");

                entity.HasOne(d => d.OriginalPurchaseTransaction)
                    .WithMany(p => p.InverseOriginalPurchaseTransaction)
                    .HasForeignKey(d => d.OriginalPurchaseTransactionId)
                    .HasConstraintName("FK_OriginalPurchaseTransaction_PurchaseTransaction");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.PurchaseTransaction)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseTransaction_Shop");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PurchaseTransaction)
                    .HasForeignKey(d => d.TypeId);

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.PurchaseTransaction)
                    .HasForeignKey(d => d.UserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseTransaction_AspNetUserDetail");
            });

            modelBuilder.Entity<PurchaseTransactionCrmSync>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PurchaseTransactionCrmSync")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CrmUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.PurchaseTransactionCrmSync)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseTransactionCrmSync_PurchaseTransaction");
            });

            modelBuilder.Entity<PurchaseTransactionDailySubtotal>(entity =>
            {
                entity.HasKey(e => e.SqlId)
                    .HasName("PK__Purchase__F430862E375FD6B3");

                entity.Property(e => e.AccumulatedAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.AccumulationPeriodEnd)
                    .HasColumnName("AccumulationPeriod_End")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccumulationPeriodStart)
                    .HasColumnName("AccumulationPeriod_Start")
                    .HasColumnType("datetime");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PurchaseTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_PurchaseTransactionDetail_1")
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PurchaseTransactionDetail")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.PurchaseTransactionId, e.ItemDescription })
                    .HasName("nci_wi_PurchaseTransactionDetail_60064DD6631376CE64CA093098702B50");

                entity.HasIndex(e => new { e.Id, e.ItemDescription, e.PurchaseProductCategoryId, e.Quantity, e.RowNumber, e.TotalAmount, e.UnitPrice, e.Uom, e.PurchaseTransactionId })
                    .HasName("nci_wi_PurchaseTransactionDetail_59C81AA4E40B60D624DD3485D306749B");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApplyToLine).HasMaxLength(100);

                entity.Property(e => e.CouponCode).HasMaxLength(100);

                entity.Property(e => e.CreateDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemDescription).HasMaxLength(100);

                entity.Property(e => e.LineNo).HasMaxLength(100);

                entity.Property(e => e.MigrationTime).HasColumnType("datetime");

                entity.Property(e => e.OriginalAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PayCode).HasMaxLength(100);

                entity.Property(e => e.PromotionDesc).HasMaxLength(100);

                entity.Property(e => e.PromotionId).HasMaxLength(100);

                entity.Property(e => e.Psp)
                    .HasColumnName("PSP")
                    .HasMaxLength(100);

                entity.Property(e => e.Qrcode)
                    .HasColumnName("QRCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RetailType).HasMaxLength(1);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.SubClassId).HasMaxLength(100);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(3);

                entity.Property(e => e.UpdateTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.PurchaseTransactionDetail)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .HasConstraintName("FK_PurchaseTransactionDetail_PurchaseTransaction");

                entity.HasOne(d => d.SalesProductMaster)
                    .WithMany(p => p.PurchaseTransactionDetail)
                    .HasForeignKey(d => d.SalesProductMasterId)
                    .HasConstraintName("FK_PurchaseTransactionDetail_SalesProductMaster");
            });

            modelBuilder.Entity<PurchaseTransactionDetailCrmSync>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PurchaseTransactionDetailCrmSync")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CrmUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PurchaseTransactionDetail)
                    .WithMany(p => p.PurchaseTransactionDetailCrmSync)
                    .HasForeignKey(d => d.PurchaseTransactionDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseTransactionDetailCrmSync_PurchaseTransactionDetail");
            });

            modelBuilder.Entity<PurchaseTransactionLineList>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PurchaseTransactionLineList")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApplyToLine).HasMaxLength(100);

                entity.Property(e => e.CouponCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.LineNo).HasMaxLength(100);

                entity.Property(e => e.NetAmt).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OriginalAmt).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PayCode).HasMaxLength(100);

                entity.Property(e => e.PromotionDesc).HasMaxLength(100);

                entity.Property(e => e.PromotionId)
                    .HasColumnName("PromotionID")
                    .HasMaxLength(100);

                entity.Property(e => e.Psp)
                    .HasColumnName("PSP")
                    .HasMaxLength(100);

                entity.Property(e => e.Qrcode)
                    .HasColumnName("QRCode")
                    .HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RetailType).HasMaxLength(1);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.SubClassid).HasMaxLength(100);

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(50);

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.PurchaseTransactionLineList)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_PurchaseTransactionLineList_PaymentType");

                entity.HasOne(d => d.ProductMaster)
                    .WithMany(p => p.PurchaseTransactionLineList)
                    .HasForeignKey(d => d.ProductMasterId)
                    .HasConstraintName("FK_PurchaseTransactionLineList_Yata.SalesProductMaster");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.PurchaseTransactionLineList)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseTransactionLineList_PurchaseTransaction");
            });

            modelBuilder.Entity<PurchaseTransactionPaymentDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PurchaseTransactionPaymentDetail")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ECouponRecordId).HasColumnName("eCouponRecordId");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.PurchaseTransactionPaymentDetail)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseTransactionPaymentDetail_PaymentType");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.PurchaseTransactionPaymentDetail)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseTransactionPaymentDetail_PurchaseTransaction");
            });

            modelBuilder.Entity<PurchaseTransactionProductCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PurchaseProductCategory)
                    .WithMany(p => p.PurchaseTransactionProductCategory)
                    .HasForeignKey(d => d.PurchaseProductCategoryId)
                    .HasConstraintName("FK_PurchaseTransactionProductCategory_PurchaseProductCategory");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.PurchaseTransactionProductCategory)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .HasConstraintName("FK_PurchaseTransactionProductCategory_PurchaseTransaction");
            });

            modelBuilder.Entity<PushClick>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PushClick")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.MarketingCostResult)
                    .WithMany(p => p.PushClick)
                    .HasForeignKey(d => d.MarketingCostResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PushClick_MarketingCostResult");
            });

            modelBuilder.Entity<ReStarter>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_ReStart");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.LastExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.ReStarter)
                    .HasForeignKey(d => d.ControlId)
                    .HasConstraintName("FK_ReStarter_Control");
            });

            modelBuilder.Entity<ReceieveLocation>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.ReceieveLocation)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_MarketId");
            });

            modelBuilder.Entity<RedeemDiscountMaster>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.DiscountType)
                    .WithMany(p => p.RedeemDiscountMaster)
                    .HasForeignKey(d => d.DiscountTypeId)
                    .HasConstraintName("FK_RedeemDiscountMaster_DiscountType");
            });

            modelBuilder.Entity<RedeemPaymentDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_PaymentDetail")
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_PaymentDetail")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.N5TraceNo, e.RedeemTransactionId })
                    .HasName("nci_wi_RedeemPaymentDetail_22502D21B4FFAFFE925006111E1E070D");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.N5AuthAmt)
                    .HasColumnName("N5_AuthAmt")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.N5CampaignId)
                    .HasColumnName("N5_CampaignId")
                    .HasMaxLength(100);

                entity.Property(e => e.N5CouponId)
                    .HasColumnName("N5_CouponId")
                    .HasMaxLength(100);

                entity.Property(e => e.N5HostRef)
                    .HasColumnName("N5_HostRef")
                    .HasMaxLength(100);

                entity.Property(e => e.N5LocalCur)
                    .HasColumnName("N5_LocalCur")
                    .HasMaxLength(50);

                entity.Property(e => e.N5Mid)
                    .HasColumnName("N5_Mid")
                    .HasMaxLength(100);

                entity.Property(e => e.N5Pan)
                    .HasColumnName("N5_Pan")
                    .HasMaxLength(100);

                entity.Property(e => e.N5PaymentType)
                    .HasColumnName("N5_PaymentType")
                    .HasMaxLength(100);

                entity.Property(e => e.N5Tid)
                    .HasColumnName("N5_Tid")
                    .HasMaxLength(100);

                entity.Property(e => e.N5TraceNo)
                    .HasColumnName("N5_TraceNo")
                    .HasMaxLength(100);

                entity.Property(e => e.N5TxnDate)
                    .HasColumnName("N5_TxnDate")
                    .HasMaxLength(100);

                entity.Property(e => e.N5TxnTime)
                    .HasColumnName("N5_TxnTime")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.RedeemTransaction)
                    .WithMany(p => p.RedeemPaymentDetail)
                    .HasForeignKey(d => d.RedeemTransactionId)
                    .HasConstraintName("FK_PaymentDetail_RedeemTransaction");
            });

            modelBuilder.Entity<RedeemProduct>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Product_1")
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_RedeemProduct")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.ConversionQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.EnglishDescription).HasMaxLength(1024);

                entity.Property(e => e.EnglishName).HasMaxLength(256);

                entity.Property(e => e.ImageUri).HasMaxLength(256);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxPurchaseQuantityPerUser).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NavItemId).HasColumnName("Nav_ItemId");

                entity.Property(e => e.PoUnitName).HasMaxLength(10);

                entity.Property(e => e.ProductCrmDisplayName).HasMaxLength(256);

                entity.Property(e => e.SafetyStockQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.UnitCrmId)
                    .HasColumnName("Unit_CrmId")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitName)
                    .HasColumnName("Unit_Name")
                    .HasMaxLength(256);

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(50);

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.DefaultPriceList)
                    .WithMany(p => p.RedeemProduct)
                    .HasForeignKey(d => d.DefaultPriceListId)
                    .HasConstraintName("FK_RedeemProduct_PriceList");

                entity.HasOne(d => d.DefaultUnit)
                    .WithMany(p => p.RedeemProduct)
                    .HasForeignKey(d => d.DefaultUnitId)
                    .HasConstraintName("FK_RedeemProduct_Unit");

                entity.HasOne(d => d.RedeemProductStructure)
                    .WithMany(p => p.RedeemProduct)
                    .HasForeignKey(d => d.RedeemProductStructureId)
                    .HasConstraintName("FK_RedeemProduct_RedeemProductStructure");

                entity.HasOne(d => d.RedeemType)
                    .WithMany(p => p.RedeemProduct)
                    .HasForeignKey(d => d.RedeemTypeId)
                    .HasConstraintName("FK_RedeemProduct_RedeemType");

                entity.HasOne(d => d.UniGroup)
                    .WithMany(p => p.RedeemProduct)
                    .HasForeignKey(d => d.UniGroupId)
                    .HasConstraintName("FK_RedeemProduct_UnitGroup");
            });

            modelBuilder.Entity<RedeemProductAssociation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.BoundleRedeemProduct)
                    .WithMany(p => p.RedeemProductAssociationBoundleRedeemProduct)
                    .HasForeignKey(d => d.BoundleRedeemProductId)
                    .HasConstraintName("FK_RedeemProductAssociation_RedeemProduct");

                entity.HasOne(d => d.RedeemPorduct)
                    .WithMany(p => p.RedeemProductAssociationRedeemPorduct)
                    .HasForeignKey(d => d.RedeemPorductId)
                    .HasConstraintName("FK_RedeemProductAssociation_RedeemProduct1");
            });

            modelBuilder.Entity<RedeemProductCategory>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.SortButtonColorIniPos)
                    .HasColumnName("SortButtonColorIniPOS")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RedeemProductStock>(entity =>
            {
                entity.HasIndex(e => new { e.MarketId, e.Quantity, e.RowVersion, e.RedeemProductId })
                    .HasName("nci_wi_RedeemProductStock_1929A975DC369EA54F55035CC2AB9C49");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.RedeemProductStock)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stock_Market");

                entity.HasOne(d => d.RedeemProduct)
                    .WithMany(p => p.RedeemProductStock)
                    .HasForeignKey(d => d.RedeemProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RedeemProductStock_RedeemProduct");
            });

            modelBuilder.Entity<RedeemProductStructure>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<RedeemTransaction>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ProductTransaction")
                    .IsClustered(false);

                entity.HasIndex(e => e.IsSyncToCrm);

                entity.HasIndex(e => e.MemberId)
                    .HasName("IX_RedeemTransaction_1");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_RedeemTransaction")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.AmountDiscount, e.CsCounterEamil, e.CscounterUserId, e.CurrencyId, e.DiscountReason, e.FinnalAmount, e.Id, e.InvoiceNumber, e.IsSyncToCrm, e.MemberId, e.PointDiscount, e.PointRedeemed, e.ToMarketId, e.TotalAmount, e.TotalPoint, e.FromMarketId, e.RedemtionTypeId, e.StatusId, e.TypeId, e.CreateTime })
                    .HasName("nci_wi_RedeemTransaction_0B917D302279766A0BBD083DEAA2E45D");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AmountDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CsCounterEamil).HasMaxLength(500);

                entity.Property(e => e.CscounterUserId)
                    .HasColumnName("CSCounterUserId")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountReason).HasMaxLength(250);

                entity.Property(e => e.FinnalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.IsSyncToCrm).HasColumnName("IsSyncToCRM");

                entity.Property(e => e.PickUpDatetime).HasColumnType("datetime");

                entity.Property(e => e.PointDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PointRedeemed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPoint).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.RedeemTransaction)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_RedeemTransaction_Currency");

                entity.HasOne(d => d.FromMarket)
                    .WithMany(p => p.RedeemTransactionFromMarket)
                    .HasForeignKey(d => d.FromMarketId)
                    .HasConstraintName("FK_ProductTransactionHeader_Market");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.RedeemTransaction)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_RedeemTransaction_Member");

                entity.HasOne(d => d.NavPurchaseRequest)
                    .WithMany(p => p.RedeemTransaction)
                    .HasForeignKey(d => d.NavPurchaseRequestId)
                    .HasConstraintName("FK_RedeemTransaction_NavPurchaseRequest");

                entity.HasOne(d => d.RedeemType)
                    .WithMany(p => p.RedeemTransaction)
                    .HasForeignKey(d => d.RedeemTypeId)
                    .HasConstraintName("FK_RedeemTransaction_RedeemType");

                entity.HasOne(d => d.RedemtionType)
                    .WithMany(p => p.RedeemTransaction)
                    .HasForeignKey(d => d.RedemtionTypeId)
                    .HasConstraintName("FK_RedeemTransaction_RedeemtionType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.RedeemTransactionStatus)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_ProductTransaction_LookupTable");

                entity.HasOne(d => d.ToMarket)
                    .WithMany(p => p.RedeemTransactionToMarket)
                    .HasForeignKey(d => d.ToMarketId)
                    .HasConstraintName("FK_ProductTransactionHeader_Market1");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.RedeemTransactionType)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_RedeemTransaction_LookupTable");
            });

            modelBuilder.Entity<RedeemTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.NavIsSync)
                    .HasName("IX_RedeemTransactionDetail_1");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_RedeemTransactionDetail")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.AmountDiscount, e.CurrencyId, e.FinnalAmount, e.FinnalPoints, e.Id, e.IsBundle, e.ItemNumber, e.NavIsSync, e.PointsDiscount, e.Quantity, e.RedeemProductId, e.TotalPoints, e.UnitPoint, e.UnitPrice, e.RedeemTransactionId, e.TotalAmount })
                    .HasName("nci_wi_RedeemTransactionDetail_EECA38D42194A67AFA0DDEA7A013AAA3");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AmountDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinnalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinnalPoints).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NavIsSync).HasColumnName("Nav_IsSync");

                entity.Property(e => e.PointsDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPoints).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPoint).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.RedeemTransactionDetail)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_RedeemTransactionDetail_Currency");

                entity.HasOne(d => d.RedeemProduct)
                    .WithMany(p => p.RedeemTransactionDetail)
                    .HasForeignKey(d => d.RedeemProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RedeemTransactionDetail_RedeemProduct");

                entity.HasOne(d => d.RedeemTransaction)
                    .WithMany(p => p.RedeemTransactionDetail)
                    .HasForeignKey(d => d.RedeemTransactionId)
                    .HasConstraintName("FK_RedeemTransactionDetail_RedeemTransaction");
            });

            modelBuilder.Entity<RedeemType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<RedeemtionType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.Id)
                    .HasName("IX_RedeemtionType")
                    .IsClustered();

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ReferenceTransactionType>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ReferrAbout>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ReferralCode>(entity =>
            {
                entity.HasIndex(e => e.UserDetailId)
                    .HasName("IX_ReferralCode")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ReferralCode)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_ReferralCode_Shop");

                entity.HasOne(d => d.UserDetail)
                    .WithOne(p => p.ReferralCode)
                    .HasForeignKey<ReferralCode>(d => d.UserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReferralCode_AspNetUserDetail");
            });

            modelBuilder.Entity<ReferralCodeUsage>(entity =>
            {
                entity.HasIndex(e => new { e.FromUserDetailId, e.ToUserDetailId })
                    .HasName("UniqueUsage")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.FromUserDetail)
                    .WithMany(p => p.ReferralCodeUsageFromUserDetail)
                    .HasForeignKey(d => d.FromUserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReferralCodeUsage_AspNetUserDetail3");

                entity.HasOne(d => d.ToUserDetail)
                    .WithMany(p => p.ReferralCodeUsageToUserDetail)
                    .HasForeignKey(d => d.ToUserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReferralCodeUsage_AspNetUserDetail2");
            });

            modelBuilder.Entity<RepeatFrequency>(entity =>
            {
                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<ReportExpirePointToRevenue>(entity =>
            {
                entity.ToTable("Report.ExpirePointToRevenue");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MainPoint).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SecondPoint).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ReportRecord>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_DecileReport")
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_DecileReport")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdfEndTime).HasColumnType("datetime");

                entity.Property(e => e.AdfRunId).HasMaxLength(50);

                entity.Property(e => e.AdfStartTime).HasColumnType("datetime");

                entity.Property(e => e.BlobCreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.LockTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.StaticListId).HasMaxLength(50);

                entity.HasOne(d => d.AzureStatusNavigation)
                    .WithMany(p => p.ReportRecord)
                    .HasForeignKey(d => d.AzureStatus)
                    .HasConstraintName("FK_DecileReportRecord_AzureStatus");

                entity.HasOne(d => d.ExportStatusNavigation)
                    .WithMany(p => p.ReportRecord)
                    .HasForeignKey(d => d.ExportStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DecileReportRecord_ExportStatus");

                entity.HasOne(d => d.ReportTypeNavigation)
                    .WithMany(p => p.ReportRecord)
                    .HasForeignKey(d => d.ReportType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportRecord_ReportType");
            });

            modelBuilder.Entity<ReportType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<RoundingDigit>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<RoundingMethod>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<SalesPaymentDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_SalesPaymentDetail")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SalesPaymentDetail)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPaymentDetail_Currency");

                entity.HasOne(d => d.SalesTransaction)
                    .WithMany(p => p.SalesPaymentDetail)
                    .HasForeignKey(d => d.SalesTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPaymentDetail_SalesTransaction");
            });

            modelBuilder.Entity<SalesTransaction>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.IsSyncToCrm);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_SalesTransaction")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IsSyncToCrm).HasColumnName("IsSyncToCRM");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TotalTransactionAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SalesTransaction)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesTransaction_Currency");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.SalesTransaction)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesTransaction_Market");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.SalesTransaction)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesTransaction_Shop");
            });

            modelBuilder.Entity<SalesTransactionDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_SalesTransactionDetail")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NavIsSync).HasColumnName("Nav_IsSync");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UniPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SalesTransactionDetail)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesTransactionDetail_Currency");

                entity.HasOne(d => d.SalesRedeemProduct)
                    .WithMany(p => p.SalesTransactionDetail)
                    .HasForeignKey(d => d.SalesRedeemProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesTransactionDetail_RedeemProduct");

                entity.HasOne(d => d.SalesTransaction)
                    .WithMany(p => p.SalesTransactionDetail)
                    .HasForeignKey(d => d.SalesTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesTransactionDetail_SalesTransaction");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.SalesTransactionDetail)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesTransactionDetail_Shop");
            });

            modelBuilder.Entity<SendResult>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<SendStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SendType>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceLock>(entity =>
            {
                entity.HasKey(e => e.SqlId);

                entity.Property(e => e.LockTime).HasColumnType("datetime");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ServiceMaster)
                    .WithMany(p => p.ServiceLock)
                    .HasForeignKey(d => d.ServiceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceLock_ServiceMaster");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.ServiceLock)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceLock_ServiceStatus");
            });

            modelBuilder.Entity<ServiceMaster>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.Id)
                    .HasName("IX_ServiceMaster")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ServiceStatus>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Sftp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.DownloadTime).HasMaxLength(50);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocaldownloadPath).HasMaxLength(50);

                entity.Property(e => e.LocaluploadPath).HasMaxLength(50);

                entity.Property(e => e.PrivateKeyPath).HasMaxLength(100);

                entity.Property(e => e.SftpPwd).HasMaxLength(50);

                entity.Property(e => e.SftpUrl).HasMaxLength(50);

                entity.Property(e => e.SftpUser).HasMaxLength(50);

                entity.Property(e => e.SftpdownloadPath).HasMaxLength(50);

                entity.Property(e => e.SftpuploadPath).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.SshHostKeyFingerprint).HasMaxLength(100);

                entity.Property(e => e.UploadTime).HasMaxLength(50);
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.Code, e.ShopCategoryId, e.MarketId, e.LocationTypeId, e.IsDeleted, e.Id })
                    .HasName("nci_wi_Shop_f3916f1c406444b7a2127368a6552ba5");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MigrationTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Floor)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.FloorId)
                    .HasConstraintName("FK_Shop_Floor");

                entity.HasOne(d => d.LocationType)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.LocationTypeId)
                    .HasConstraintName("FK_Shop_LocationType");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_Shop_Market");

                entity.HasOne(d => d.ShopCategory)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.ShopCategoryId)
                    .HasConstraintName("FK_Shop_ShopCategory");
            });

            modelBuilder.Entity<ShopCategory>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<ShopSharePoint>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RslModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.SharePoint).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.BenefitsMaster)
                    .WithMany(p => p.ShopSharePoint)
                    .HasForeignKey(d => d.BenefitsMasterId)
                    .HasConstraintName("FK_ShopSharePoint_BenefitsMaster");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ShopSharePoint)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_ShopSharePoint_Shop");
            });

            modelBuilder.Entity<ShortUrlRecord>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Id")
                    .IsClustered(false);

                entity.HasIndex(e => e.ShortUrlCode);

                entity.HasIndex(e => e.SqlId)
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.OriginalUrl)
                    .IsRequired()
                    .HasMaxLength(2083);

                entity.Property(e => e.ShortUrlCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.MarketingCostRecord)
                    .WithMany(p => p.ShortUrlRecord)
                    .HasForeignKey(d => d.MarketingCostRecordId)
                    .HasConstraintName("FK_ShortUrlRecord_MarketingCostRecord");
            });

            modelBuilder.Entity<SmsisClick>(entity =>
            {
                entity.ToTable("SMSIsClick");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SmsstatusCode>(entity =>
            {
                entity.ToTable("SMSStatusCode");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.StatusFlag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Switch>(entity =>
            {
                entity.HasKey(e => e.CrmId);

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.StartDate, e.EndDate })
                    .HasName("IX_Tag_StartAndEndDate");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Fixedday).HasMaxLength(50);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransactionPoint).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Accumulation)
                    .WithMany(p => p.Tag)
                    .HasForeignKey(d => d.AccumulationId)
                    .HasConstraintName("FK_AccumulationId_Accumulation");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Tag)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryId_TagCategory");

                entity.HasOne(d => d.Floor)
                    .WithMany(p => p.Tag)
                    .HasForeignKey(d => d.FloorId)
                    .HasConstraintName("FK_Tag_Floor");

                entity.HasOne(d => d.MarketingCostType)
                    .WithMany(p => p.Tag)
                    .HasForeignKey(d => d.MarketingCostTypeId)
                    .HasConstraintName("FK_Tag_MarketingCostType");

                entity.HasOne(d => d.MonthOrWeek)
                    .WithMany(p => p.Tag)
                    .HasForeignKey(d => d.MonthOrWeekId)
                    .HasConstraintName("FK_MonthOrWeekId_MonthOrWeek");

                entity.HasOne(d => d.OperatorAmount)
                    .WithMany(p => p.TagOperatorAmount)
                    .HasForeignKey(d => d.OperatorAmountId)
                    .HasConstraintName("FK_OperatorAmountId_ClfOperator");

                entity.HasOne(d => d.OperatorFrequency)
                    .WithMany(p => p.TagOperatorFrequency)
                    .HasForeignKey(d => d.OperatorFrequencyId)
                    .HasConstraintName("FK_Tag_TagOperator");

                entity.HasOne(d => d.OperatorParkingHours)
                    .WithMany(p => p.TagOperatorParkingHours)
                    .HasForeignKey(d => d.OperatorParkingHoursId)
                    .HasConstraintName("FK_Tag_Operator");

                entity.HasOne(d => d.OperatorPoint)
                    .WithMany(p => p.TagOperatorPoint)
                    .HasForeignKey(d => d.OperatorPointId)
                    .HasConstraintName("FK_OperatorPointId_ClfOperator");

                entity.HasOne(d => d.PrevTag)
                    .WithMany(p => p.InversePrevTag)
                    .HasForeignKey(d => d.PrevTagId)
                    .HasConstraintName("FK_Tag_Tag");

                entity.HasOne(d => d.ShopCategory)
                    .WithMany(p => p.Tag)
                    .HasForeignKey(d => d.ShopCategoryId)
                    .HasConstraintName("FK_Tag_PurchaseProductCategory");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tag)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_Tag_Shop");

                entity.HasOne(d => d.TagCustCategory)
                    .WithMany(p => p.Tag)
                    .HasForeignKey(d => d.TagCustCategoryId)
                    .HasConstraintName("FK_Tag_TagCustCategory");

                entity.HasOne(d => d.TagGroup)
                    .WithMany(p => p.Tag)
                    .HasForeignKey(d => d.TagGroupId)
                    .HasConstraintName("FK_Tag_TagGroup");
            });

            modelBuilder.Entity<TagCategory>(entity =>
            {
                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.EnName).HasMaxLength(50);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TagCustCategory>(entity =>
            {
                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TagGroup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_TagGroup")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TagMonthOrWeek>(entity =>
            {
                entity.Property(e => e.EnName).HasMaxLength(50);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TagOperator>(entity =>
            {
                entity.Property(e => e.EnName).HasMaxLength(50);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TempMarketingTransactionReprot>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PurchaseTransactionTransactionAmount).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PurchaseTransactionTransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.SqlIdd).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.C1)
                    .HasColumnName("c1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.C2).HasColumnName("c2");
            });

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TimeUnit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ChineseUnitName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Timer>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ExecuteSyncDate).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.Timer)
                    .HasForeignKey(d => d.ControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Timer_AccessLocationDetail");

                entity.HasOne(d => d.ControlItem)
                    .WithMany(p => p.Timer)
                    .HasForeignKey(d => d.ControlItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Timer_ControlItem");

                entity.HasOne(d => d.TimeUnit)
                    .WithMany(p => p.Timer)
                    .HasForeignKey(d => d.TimeUnitId)
                    .HasConstraintName("FK_Timer_TimeUnit");
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Token")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiresIn).HasColumnType("datetime");

                entity.Property(e => e.RefreshToken).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TransactionMethod>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<TransactionStatus>(entity =>
            {
                entity.HasOne(d => d.ProcessStatus)
                    .WithMany(p => p.TransactionStatus)
                    .HasForeignKey(d => d.ProcessStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionStatus_LookupTable");

                entity.HasOne(d => d.PurchaseTransaction)
                    .WithMany(p => p.TransactionStatus)
                    .HasForeignKey(d => d.PurchaseTransactionId)
                    .HasConstraintName("FK_TransactionStatus_PurchaseTransaction");
            });

            modelBuilder.Entity<TransactionSummaryReport>(entity =>
            {
                entity.Property(e => e.CredateTime).HasColumnType("datetime");

                entity.Property(e => e.Discount)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GrossAmount)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MerchantName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MerchantNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NetAmount)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TxCurrency)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateUser).HasMaxLength(50);
            });

            modelBuilder.Entity<Trigger>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Trigger")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ExecuteSyncDate).HasColumnType("datetime");

                entity.Property(e => e.ExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.Trigger)
                    .HasForeignKey(d => d.ControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trigger_AccessLocationDetail");

                entity.HasOne(d => d.ControlItem)
                    .WithMany(p => p.Trigger)
                    .HasForeignKey(d => d.ControlItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trigger_ControlItem");
            });

            modelBuilder.Entity<TypeOfField>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<UnitGroup>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CredateTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LogingName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserPoint>(entity =>
            {
                entity.HasIndex(e => new { e.Point, e.UserDetailId })
                    .HasName("nci_wi_UserPoint_B930C9557558BF91626A960C65177EB2");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Point).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rowversion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ActivityPointExpireTime)
                    .WithMany(p => p.UserPoint)
                    .HasForeignKey(d => d.ActivityPointExpireTimeId)
                    .HasConstraintName("FK_UserPoint_ActivityPointExpireTime");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.UserPoint)
                    .HasForeignKey(d => d.UserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPoint_AspNetUserDetail");
            });

            modelBuilder.Entity<VContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Contact");

                entity.Property(e => e.BuildingName).HasMaxLength(50);

                entity.Property(e => e.ChineseLastName).HasMaxLength(256);

                entity.Property(e => e.ChineseName).HasMaxLength(256);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstLoginTime).HasColumnType("datetime");

                entity.Property(e => e.Floor).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MemberNo).HasMaxLength(50);

                entity.Property(e => e.MigrationTime).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(256);

                entity.Property(e => e.Sfid).HasMaxLength(50);

                entity.Property(e => e.SmsoptOut).HasColumnName("SMSOptOut");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateStamp).HasMaxLength(50);
            });

            modelBuilder.Entity<VMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Member");

                entity.Property(e => e.MemberStatusReason).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<VipCardRecords>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_VipCardRecords")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdditionalMemberName).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ApplyLocation).HasMaxLength(100);

                entity.Property(e => e.CardNo).HasMaxLength(50);

                entity.Property(e => e.CardType).HasMaxLength(50);

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.CrmCardDetailId).HasColumnName("crmCardDetailId");

                entity.Property(e => e.CrmContactId).HasColumnName("crmContactId");

                entity.Property(e => e.CrmMemberId).HasColumnName("crmMemberId");

                entity.Property(e => e.ErrorMsg).HasMaxLength(100);

                entity.Property(e => e.FormalErrorMsg).HasMaxLength(1000);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MemberName).HasMaxLength(50);

                entity.Property(e => e.ModifyOn).HasColumnType("datetime");

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.VipCardNo).HasMaxLength(50);

                entity.HasOne(d => d.Progress)
                    .WithMany(p => p.VipCardRecords)
                    .HasForeignKey(d => d.ProgressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VipCardRecords_VipGeneratorProgress");

                entity.HasOne(d => d.StatusCode)
                    .WithMany(p => p.VipCardRecords)
                    .HasForeignKey(d => d.StatusCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VipCardRecords_VipCardStatusCode");
            });

            modelBuilder.Entity<VipCardStatusCode>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<VipCardType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VipGeneratorProgress>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => e.IsDisable);

                entity.HasIndex(e => e.ModifyOn);

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_VipGeneratorProgress")
                    .IsClustered();

                entity.HasIndex(e => e.StatusCodeId);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Args).HasMaxLength(100);

                entity.Property(e => e.CreateOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorInfo).HasMaxLength(200);

                entity.Property(e => e.ErrorMsg).HasMaxLength(100);

                entity.Property(e => e.ModifyOn).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.StatusCode)
                    .WithMany(p => p.VipGeneratorProgress)
                    .HasForeignKey(d => d.StatusCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VipGeneratorProgress_VipCardStatusCode");
            });

            modelBuilder.Entity<VipGroup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.MembershipExpiration)
                    .WithMany(p => p.VipGroup)
                    .HasForeignKey(d => d.MembershipExpirationId)
                    .HasConstraintName("FK_VipGroup_MembershipExpirationAndCumulativePeriod");
            });

            modelBuilder.Entity<WaivedType>(entity =>
            {
                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiredOn).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.WaivedAmount).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<YataAspNetUserStateCode>(entity =>
            {
                entity.ToTable("Yata.AspNetUserStateCode");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataCeilingType>(entity =>
            {
                entity.ToTable("Yata.CeilingType");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataCountry>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.Country");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.Country")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CrmCreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CrmId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameC).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YataCountryCode>(entity =>
            {
                entity.ToTable("Yata.CountryCode");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataECouponGenerationStatus>(entity =>
            {
                entity.ToTable("Yata.eCouponGenerationStatus");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataECouponMarket>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.eCouponMarket");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.eCouponMarket")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ECouponSettingId).HasColumnName("eCouponSettingId");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ECouponSetting)
                    .WithMany(p => p.YataECouponMarket)
                    .HasForeignKey(d => d.ECouponSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Yata.eCouponMarket_Yata.eCouponSetting");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.YataECouponMarket)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Yata.eCouponMarket_Market");
            });

            modelBuilder.Entity<YataECouponRecord>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.eCouponRecord");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.eCouponRecord")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedBySfid)
                    .HasColumnName("CreatedBySFID")
                    .HasMaxLength(50);

                entity.Property(e => e.ECouponApplicableStore).HasColumnName("eCoupon_ApplicableStore");

                entity.Property(e => e.ECouponCode)
                    .HasColumnName("eCouponCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ECouponCouponGenerationCompleteTime)
                    .HasColumnName("eCoupon_CouponGenerationCompleteTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponCouponGenerationDateTime)
                    .HasColumnName("eCoupon_CouponGenerationDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponCouponGenerationStatusId).HasColumnName("eCoupon_CouponGenerationStatusId");

                entity.Property(e => e.ECouponCouponId)
                    .HasColumnName("eCoupon_CouponId")
                    .HasMaxLength(50);

                entity.Property(e => e.ECouponCouponName)
                    .HasColumnName("eCoupon_CouponName")
                    .HasMaxLength(100);

                entity.Property(e => e.ECouponCouponRedemptionTime).HasColumnName("eCoupon_CouponRedemptionTime");

                entity.Property(e => e.ECouponCouponTypeId).HasColumnName("eCoupon_CouponTypeId");

                entity.Property(e => e.ECouponCouponValidFrom)
                    .HasColumnName("eCoupon_CouponValidFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponCouponValidTo)
                    .HasColumnName("eCoupon_CouponValidTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponCouponValidationPeriod).HasColumnName("eCoupon_CouponValidationPeriod");

                entity.Property(e => e.ECouponCouponValidationType).HasColumnName("eCoupon_CouponValidationType");

                entity.Property(e => e.ECouponCouponValue).HasColumnName("eCoupon_CouponValue");

                entity.Property(e => e.ECouponECouponMaxRedeemQty).HasColumnName("eCoupon_eCouponMaxRedeemQty");

                entity.Property(e => e.ECouponMarketingListId).HasColumnName("eCoupon_MarketingListId");

                entity.Property(e => e.ECouponMemberQuota).HasColumnName("eCoupon_MemberQuota");

                entity.Property(e => e.ECouponMotherProductId).HasColumnName("eCoupon_MotherProductId");

                entity.Property(e => e.ECouponPasscode)
                    .HasColumnName("eCoupon_passcode")
                    .HasMaxLength(50);

                entity.Property(e => e.ECouponPinToTop).HasColumnName("eCoupon_PinToTop");

                entity.Property(e => e.ECouponRedeemable).HasColumnName("eCoupon_Redeemable");

                entity.Property(e => e.ECouponRequierdPoint).HasColumnName("eCoupon_RequierdPoint");

                entity.Property(e => e.ECouponRewardEffectiveFrom)
                    .HasColumnName("eCoupon_RewardEffectiveFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponRewardEffectiveTo)
                    .HasColumnName("eCoupon_RewardEffectiveTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponRewardGroup).HasColumnName("eCoupon_RewardGroup");

                entity.Property(e => e.ECouponRewardIssuingTypeId).HasColumnName("eCoupon_RewardIssuingTypeId");

                entity.Property(e => e.ECouponRewardPostingFrom)
                    .HasColumnName("eCoupon_RewardPostingFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponRewardPostingTo)
                    .HasColumnName("eCoupon_RewardPostingTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponRewardSubTypeId).HasColumnName("eCoupon_RewardSubTypeId");

                entity.Property(e => e.ECouponSettingId).HasColumnName("eCouponSettingId");

                entity.Property(e => e.ECouponTesting).HasColumnName("eCoupon_Testing");

                entity.Property(e => e.ECouponTestingMemberSchemeId).HasColumnName("eCoupon_TestingMemberSchemeId");

                entity.Property(e => e.EcouponStatusId).HasColumnName("ECouponStatusId");

                entity.Property(e => e.IssueFromSfid)
                    .HasColumnName("IssueFromSFID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedBySfid)
                    .HasColumnName("LastModifiedBySFID")
                    .HasMaxLength(50);

                entity.Property(e => e.MigrationTime).HasColumnType("datetime");

                entity.Property(e => e.Qrcode)
                    .HasColumnName("QRCode")
                    .HasMaxLength(50);

                entity.Property(e => e.RedeemDate).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionSfid)
                    .HasColumnName("TransactionSFID")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UsedDate).HasColumnType("datetime");

                entity.Property(e => e.UsedInPosid)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.ECouponRewardSubType)
                    .WithMany(p => p.YataECouponRecord)
                    .HasForeignKey(d => d.ECouponRewardSubTypeId)
                    .HasConstraintName("FK_Yata.eCouponRecord_Yata.RewardSubType");

                entity.HasOne(d => d.ECouponSetting)
                    .WithMany(p => p.YataECouponRecord)
                    .HasForeignKey(d => d.ECouponSettingId)
                    .HasConstraintName("FK_Yata.eCouponRecord_Yata.eCouponSetting");

                entity.HasOne(d => d.EcouponStatus)
                    .WithMany(p => p.YataECouponRecord)
                    .HasForeignKey(d => d.EcouponStatusId)
                    .HasConstraintName("FK_Yata.eCouponRecord_Yata.eCouponStatus");

                entity.HasOne(d => d.IssueFromPurchaseTxn)
                    .WithMany(p => p.YataECouponRecord)
                    .HasForeignKey(d => d.IssueFromPurchaseTxnId)
                    .HasConstraintName("FK_Yata.eCouponRecord_PurchaseTransaction");

                entity.HasOne(d => d.RedeemProduct)
                    .WithMany(p => p.YataECouponRecord)
                    .HasForeignKey(d => d.RedeemProductId)
                    .HasConstraintName("FK_Yata.eCouponRecord_Yata.RedeemProductMaster");

                entity.HasOne(d => d.RedeemTransaction)
                    .WithMany(p => p.YataECouponRecord)
                    .HasForeignKey(d => d.RedeemTransactionId)
                    .HasConstraintName("FK_Yata.eCouponRecord_Yata.RedeemTransaction");

                entity.HasOne(d => d.UsedinMarket)
                    .WithMany(p => p.YataECouponRecord)
                    .HasForeignKey(d => d.UsedinMarketId)
                    .HasConstraintName("FK_Yata.eCouponRecord_Market");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.YataECouponRecord)
                    .HasForeignKey(d => d.UserDetailId)
                    .HasConstraintName("FK_Yata.eCouponRecord_AspNetUserDetail");
            });

            modelBuilder.Entity<YataECouponSetting>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.eCouponSetting");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.eCouponSetting")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CouponSubtitleC).HasMaxLength(100);

                entity.Property(e => e.CouponSubtitleE).HasMaxLength(100);

                entity.Property(e => e.CouponTitleC).HasMaxLength(100);

                entity.Property(e => e.CouponTitleE).HasMaxLength(100);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ECouponGenerationCompleteTime)
                    .HasColumnName("eCouponGenerationCompleteTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponGenerationDateTime)
                    .HasColumnName("eCouponGenerationDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponGenerationStatusId).HasColumnName("eCouponGenerationStatusId");

                entity.Property(e => e.ECouponId)
                    .HasColumnName("eCouponId")
                    .HasMaxLength(50);

                entity.Property(e => e.ECouponRedemptionTime).HasColumnName("eCouponRedemptionTime");

                entity.Property(e => e.ECouponTypeId).HasColumnName("eCouponTypeId");

                entity.Property(e => e.ECouponValidFrom)
                    .HasColumnName("eCouponValidFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponValidTo)
                    .HasColumnName("eCouponValidTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.ECouponValidationPeriod).HasColumnName("eCouponValidationPeriod");

                entity.Property(e => e.ECouponValidationTypeId).HasColumnName("eCouponValidationTypeId");

                entity.Property(e => e.ECouponValue).HasColumnName("eCouponValue");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PassCode).HasMaxLength(6);

                entity.Property(e => e.Prefix).HasMaxLength(2);

                entity.Property(e => e.RewardEffectiveFrom).HasColumnType("datetime");

                entity.Property(e => e.RewardEffectiveTo).HasColumnType("datetime");

                entity.Property(e => e.RewardPostingFrom).HasColumnType("datetime");

                entity.Property(e => e.RewardPostingTo).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.Tcc).HasColumnName("TCC");

                entity.Property(e => e.Tce).HasColumnName("TCE");

                entity.HasOne(d => d.MotherProduct)
                    .WithMany(p => p.YataECouponSetting)
                    .HasForeignKey(d => d.MotherProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Yata.eCouponSetting_Yata.MotherProduct");
            });

            modelBuilder.Entity<YataECouponStatus>(entity =>
            {
                entity.ToTable("Yata.eCouponStatus");

                entity.Property(e => e.ChineseName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataECouponType>(entity =>
            {
                entity.ToTable("Yata.eCouponType");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataECouponValidationType>(entity =>
            {
                entity.ToTable("Yata.eCouponValidationType");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataFamilyStatusCode>(entity =>
            {
                entity.ToTable("Yata.FamilyStatusCode");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataFixContent>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.FixContent");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.FixContent")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContentCode).HasMaxLength(100);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.DetailPath).HasMaxLength(200);

                entity.Property(e => e.Header).HasMaxLength(100);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YataFixContentType>(entity =>
            {
                entity.ToTable("Yata.FixContentType");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataInterest>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.Interest");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.Interest")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmCreateOnTime).HasColumnType("datetime");

                entity.Property(e => e.CrmId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.EnglishName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<YataLanguage>(entity =>
            {
                entity.ToTable("Yata.Language");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataList>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.List");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.List")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.LastUsedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Purpose)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YataMotherProduct>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.MotherProduct");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.MotherProduct")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YataNoBonusPointList>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Yata.ExcludeBonusProduct")
                    .IsClustered(false);

                entity.ToTable("Yata.NoBonusPointList");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.NoBonusPointList")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YataPinToTop>(entity =>
            {
                entity.ToTable("Yata.PinToTop");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataPointAdjustmentHistory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Yata.PointAdjustmentHistory_1")
                    .IsClustered(false);

                entity.ToTable("Yata.PointAdjustmentHistory");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.PointAdjustmentHistory_1")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpireOn).HasColumnType("datetime");

                entity.Property(e => e.ExternalRemark).HasMaxLength(100);

                entity.Property(e => e.InternalRemark).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Point).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.PointTransaction)
                    .WithMany(p => p.YataPointAdjustmentHistory)
                    .HasForeignKey(d => d.PointTransactionId)
                    .HasConstraintName("FK_Yata.PointAdjustmentHistory_PointTransaction");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.YataPointAdjustmentHistory)
                    .HasForeignKey(d => d.UserDetailId)
                    .HasConstraintName("FK_Yata.PointAdjustmentHistory_AspNetUserDetail");
            });

            modelBuilder.Entity<YataPointHistoryType>(entity =>
            {
                entity.ToTable("Yata.PointHistoryType");

                entity.Property(e => e.ImageUrl).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Namec).HasMaxLength(50);
            });

            modelBuilder.Entity<YataPopUp>(entity =>
            {
                entity.ToTable("Yata.PopUp");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataPromotionBanner>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.PromotionBanner");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.PromotionBanner")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BannerTitleC).HasMaxLength(100);

                entity.Property(e => e.BannerTitleE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BigBannerImage10C).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage10E).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage1C).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage1E).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage2C).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage2E).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage3C).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage3E).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage4C).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage4E).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage5C).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage5E).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage6C).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage6E).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage7C).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage7E).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage8C).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage8E).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage9C).HasMaxLength(1000);

                entity.Property(e => e.BigBannerImage9E).HasMaxLength(1000);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.HomeBannerDetailPathC).HasMaxLength(100);

                entity.Property(e => e.HomeBannerDetailPathE).HasMaxLength(100);

                entity.Property(e => e.MainTextC).HasMaxLength(2000);

                entity.Property(e => e.MainTextE)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PopUpImageC).HasMaxLength(1000);

                entity.Property(e => e.PopUpImageE).HasMaxLength(1000);

                entity.Property(e => e.PopUpPostingFromDate).HasColumnType("datetime");

                entity.Property(e => e.PopUpPostingToDate).HasColumnType("datetime");

                entity.Property(e => e.PostingFromDate).HasColumnType("datetime");

                entity.Property(e => e.PostingToDate).HasColumnType("datetime");

                entity.Property(e => e.PromotionBannerNo).HasMaxLength(100);

                entity.Property(e => e.RemarkTextC).HasMaxLength(1000);

                entity.Property(e => e.RemarkTextE)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SmallBannerImageC).HasMaxLength(1000);

                entity.Property(e => e.SmallBannerImageE).HasMaxLength(1000);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TcE).IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.VideoPathC).HasMaxLength(100);

                entity.Property(e => e.VideoPathE).HasMaxLength(100);

                entity.Property(e => e.VideoThumbnailImageC).HasMaxLength(100);

                entity.Property(e => e.VideoThumbnailImageE).HasMaxLength(100);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.YataPromotionBanner)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Yata.PromotionBanner_Yata.PromotionBannerCategory");

                entity.HasOne(d => d.PinToTop)
                    .WithMany(p => p.YataPromotionBanner)
                    .HasForeignKey(d => d.PinToTopId)
                    .HasConstraintName("FK_Yata.PromotionBanner_Yata.PinToTop");
            });

            modelBuilder.Entity<YataPromotionBannerCategory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.PromotionBannerCategory");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.PromotionBannerCategory")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.NameC).HasMaxLength(100);

                entity.Property(e => e.NameE).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YataRedeemProductMaster>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.RedeemProductMaster");

                entity.HasIndex(e => e.MotherProductId)
                    .HasName("IX_Yata.RedeemProductMaster_1");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.RedeemProductMaster")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.RewardId).HasMaxLength(100);

                entity.Property(e => e.SpecC).HasMaxLength(100);

                entity.Property(e => e.SpecE).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(100);

                entity.HasOne(d => d.MotherProduct)
                    .WithMany(p => p.YataRedeemProductMaster)
                    .HasForeignKey(d => d.MotherProductId)
                    .HasConstraintName("FK_Yata.RedeemProductMaster_Yata.MotherProduct");
            });

            modelBuilder.Entity<YataRedeemProductRedeemedCount>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.RedeemProductRedeemedCount");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.RedeemProductRedeemedCount")
                    .IsClustered();

                entity.HasIndex(e => new { e.MarketId, e.RedeemProductMasterId })
                    .HasName("IX_Yata.RedeemProductRedeemedCount_1");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.YataRedeemProductRedeemedCount)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_Yata.RedeemProductRedeemedCount_Market");

                entity.HasOne(d => d.RedeemProductMaster)
                    .WithMany(p => p.YataRedeemProductRedeemedCount)
                    .HasForeignKey(d => d.RedeemProductMasterId)
                    .HasConstraintName("FK_Yata.RedeemProductRedeemedCount_Yata.RedeemProductMaster");
            });

            modelBuilder.Entity<YataRedeemProductRedeemedNonStoreQuotaCount>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.RedeemProductRedeemedNonStoreQuotaCount");

                entity.HasIndex(e => e.RedeemProductMasterId)
                    .HasName("IX_Yata.RedeemProductRedeemedNonStoreQuotaCount_1");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.RedeemProductRedeemedNonStoreQuotaCount")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<YataRedeemProductStockQuota>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Yata.StockQuota")
                    .IsClustered(false);

                entity.ToTable("Yata.RedeemProductStockQuota");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.RedeemProductStockQuota")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.YataRedeemProductStockQuota)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_Yata.StockQuota_Market");

                entity.HasOne(d => d.MotherProduct)
                    .WithMany(p => p.YataRedeemProductStockQuota)
                    .HasForeignKey(d => d.MotherProductId)
                    .HasConstraintName("FK_Yata.RedeemProductStockQuota_Yata.MotherProduct");

                entity.HasOne(d => d.RedeemProductMaster)
                    .WithMany(p => p.YataRedeemProductStockQuota)
                    .HasForeignKey(d => d.RedeemProductMasterId)
                    .HasConstraintName("FK_Yata.RedeemProductStockQuota_Yata.RedeemProductMaster");
            });

            modelBuilder.Entity<YataRedeemTransaction>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.RedeemTransaction");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.RedeemTransaction")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.EcouponSettingNameC)
                    .HasColumnName("ECouponSettingNameC")
                    .HasMaxLength(100);

                entity.Property(e => e.EcouponSettingNameE)
                    .HasColumnName("ECouponSettingNameE")
                    .HasMaxLength(100);

                entity.Property(e => e.PhysicalCardNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Market)
                    .WithMany(p => p.YataRedeemTransaction)
                    .HasForeignKey(d => d.MarketId)
                    .HasConstraintName("FK_Yata.RedeemTransaction_Market");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.YataRedeemTransaction)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Yata.RedeemTransaction_LookupTable");

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.YataRedeemTransaction)
                    .HasForeignKey(d => d.UserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Yata.RedeemTransaction_AspNetUserDetail");
            });

            modelBuilder.Entity<YataReedemImage>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Yata.ImageEntity")
                    .IsClustered(false);

                entity.ToTable("Yata.ReedemImage");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.ReedemImage")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ECouponSettingId).HasColumnName("eCouponSettingId");

                entity.Property(e => e.ImageUrl).HasColumnName("ImageURL");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.VideoUrl).HasColumnName("VideoURL");

                entity.HasOne(d => d.ECouponSetting)
                    .WithMany(p => p.YataReedemImage)
                    .HasForeignKey(d => d.ECouponSettingId)
                    .HasConstraintName("FK_Yata.ReedemImage_Yata.eCouponSetting");
            });

            modelBuilder.Entity<YataRegion>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.Region");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.Region")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmCreatedTime).HasColumnType("datetime");

                entity.Property(e => e.CrmId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RegionNamec).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.YataRegion)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Yata.Region_Yata.Country");
            });

            modelBuilder.Entity<YataRegisterLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.RegisterLog");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.RegisterLog")
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).HasMaxLength(200);

                entity.Property(e => e.PhoneNumber).HasMaxLength(256);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YataRewardIssuingType>(entity =>
            {
                entity.ToTable("Yata.RewardIssuingType");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<YataRewardSubType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.RewardSubType");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.RewardSubType")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RewardSubTypeE).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YataSalesProductBrand>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.SalesProductBrand");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.SalesProductBrand")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YataSalesProductCategory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.SalesProductCategory");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.SalesProductCategory")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Bbcategory).HasColumnName("BBCategory");

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<YataSalesProductMaster>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.SalesProductMaster");

                entity.HasIndex(e => e.ItemUpc)
                    .HasName("IX_Yata.SalesProductMaster_1");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.SalesProductMaster")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CrmId).HasMaxLength(50);

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemUpc)
                    .HasColumnName("ItemUPC")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.YataSalesProductMaster)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_Yata.SalesProductMaster_Yata.SalesProductBrand");
            });

            modelBuilder.Entity<YataSalutation>(entity =>
            {
                entity.ToTable("Yata.Salutation");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Namec).HasMaxLength(50);
            });

            modelBuilder.Entity<YataUserDeliveryAddress>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Yata.UserDeliveryAddress");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.UserDeliveryAddress")
                    .IsClustered();

                entity.HasIndex(e => new { e.Id, e.IsDeleted })
                    .HasName("IX_Yata.UserDeliveryAddress_1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Address2).HasMaxLength(1000);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.UserDetail)
                    .WithMany(p => p.YataUserDeliveryAddress)
                    .HasForeignKey(d => d.UserDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Yata.User__UserD__0EA3FC40");
            });

            modelBuilder.Entity<YataUserDetailInterest>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Yata.UserDetailInsterest")
                    .IsClustered(false);

                entity.ToTable("Yata.UserDetailInterest");

                entity.HasIndex(e => e.SqlId)
                    .HasName("IX_Yata.UserDetailInterest")
                    .IsClustered();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CrmModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.SqlId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Interest)
                    .WithMany(p => p.YataUserDetailInterest)
                    .HasForeignKey(d => d.InterestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Yata.UserDetailInterest_Yata.Interest");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.YataUserDetailInterest)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Yata.UserDetailInterest_AspNetUserDetail");
            });

            modelBuilder.HasSequence("CardNumberSequence").StartsAt(9000000);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
