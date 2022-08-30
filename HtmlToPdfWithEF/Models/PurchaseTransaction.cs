using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PurchaseTransaction
    {
        public PurchaseTransaction()
        {
            EcouponRecord = new HashSet<EcouponRecord>();
            GamePoint = new HashSet<GamePoint>();
            InverseModifyPurchaseTransaction = new HashSet<PurchaseTransaction>();
            InverseOriginalPurchaseTransaction = new HashSet<PurchaseTransaction>();
            LotteryContactPurchaseTransaction = new HashSet<LotteryContactPurchaseTransaction>();
            ParkingPayment = new HashSet<ParkingPayment>();
            PointTransaction = new HashSet<PointTransaction>();
            PurchaseTransactionCrmSync = new HashSet<PurchaseTransactionCrmSync>();
            PurchaseTransactionDetail = new HashSet<PurchaseTransactionDetail>();
            PurchaseTransactionLineList = new HashSet<PurchaseTransactionLineList>();
            PurchaseTransactionPaymentDetail = new HashSet<PurchaseTransactionPaymentDetail>();
            PurchaseTransactionProductCategory = new HashSet<PurchaseTransactionProductCategory>();
            TransactionStatus = new HashSet<TransactionStatus>();
            YataECouponRecord = new HashSet<YataECouponRecord>();
        }

        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid UserDetailId { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string InvoiceNumber { get; set; }
        public string PhysicalCardNumber { get; set; }
        public string MembershipCardId { get; set; }
        public int? MarketId { get; set; }
        public int ShopId { get; set; }
        public string MachineId { get; set; }
        public string Currency { get; set; }
        public decimal TransactionAmount { get; set; }
        public Guid? ModifyPurchaseTransactionId { get; set; }
        public int? TypeId { get; set; }
        public string CscounterId { get; set; }
        public bool? IsAlreadyModifiedPoint { get; set; }
        public bool? IsSyncToCrm { get; set; }
        public int? MemberSchemeTypeId { get; set; }
        public DateTime? UpdateTimeStamp { get; set; }
        public DateTime CreateDateTime { get; set; }
        public bool? IsZeroPoint { get; set; }
        public string ReceiptNumber { get; set; }
        public string PosNo { get; set; }
        public bool IsSelfShop { get; set; }
        public DateTime? DiscountTransactionDateTime { get; set; }
        public DateTime? MigrationTime { get; set; }
        public Guid? OriginalPurchaseTransactionId { get; set; }
        public int? HistoryTypeId { get; set; }

        public virtual YataPointHistoryType HistoryType { get; set; }
        public virtual Market Market { get; set; }
        public virtual MemberSchemeType MemberSchemeType { get; set; }
        public virtual PurchaseTransaction ModifyPurchaseTransaction { get; set; }
        public virtual PurchaseTransaction OriginalPurchaseTransaction { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual LookupTable Type { get; set; }
        public virtual AspNetUserDetail UserDetail { get; set; }
        public virtual ICollection<EcouponRecord> EcouponRecord { get; set; }
        public virtual ICollection<GamePoint> GamePoint { get; set; }
        public virtual ICollection<PurchaseTransaction> InverseModifyPurchaseTransaction { get; set; }
        public virtual ICollection<PurchaseTransaction> InverseOriginalPurchaseTransaction { get; set; }
        public virtual ICollection<LotteryContactPurchaseTransaction> LotteryContactPurchaseTransaction { get; set; }
        public virtual ICollection<ParkingPayment> ParkingPayment { get; set; }
        public virtual ICollection<PointTransaction> PointTransaction { get; set; }
        public virtual ICollection<PurchaseTransactionCrmSync> PurchaseTransactionCrmSync { get; set; }
        public virtual ICollection<PurchaseTransactionDetail> PurchaseTransactionDetail { get; set; }
        public virtual ICollection<PurchaseTransactionLineList> PurchaseTransactionLineList { get; set; }
        public virtual ICollection<PurchaseTransactionPaymentDetail> PurchaseTransactionPaymentDetail { get; set; }
        public virtual ICollection<PurchaseTransactionProductCategory> PurchaseTransactionProductCategory { get; set; }
        public virtual ICollection<TransactionStatus> TransactionStatus { get; set; }
        public virtual ICollection<YataECouponRecord> YataECouponRecord { get; set; }
    }
}
