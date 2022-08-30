using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PointTransaction
    {
        public PointTransaction()
        {
            ParkingPayment = new HashSet<ParkingPayment>();
            PointTransactionCrmSync = new HashSet<PointTransactionCrmSync>();
            PointTransactionDetail = new HashSet<PointTransactionDetail>();
            YataPointAdjustmentHistory = new HashSet<YataPointAdjustmentHistory>();
        }

        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? PurchaseTransactionId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public int? MarketId { get; set; }
        public Guid? UserDetailId { get; set; }
        public int? MemberId { get; set; }
        public int? MemberDiscountId { get; set; }
        public int? TransationMethodId { get; set; }
        public decimal? RealPoint { get; set; }
        public int? ChangePointReasonId { get; set; }
        public Guid? RedeemTransactionId { get; set; }
        public int? ApproveStatusId { get; set; }
        public int? TypeId { get; set; }
        public int? MemberSchemeTypeId { get; set; }
        public DateTime? UpdateTimeStamp { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string PhysicalCardNumber { get; set; }
        public Guid? PointTypeId { get; set; }
        public int? ShopId { get; set; }
        public int? StatusTypeId { get; set; }
        public DateTime? MigrationTime { get; set; }
        public int? SourceFrom { get; set; }
        public decimal? DisplayPoint { get; set; }

        public virtual ApproveStatus ApproveStatus { get; set; }
        public virtual ChangePointReason ChangePointReason { get; set; }
        public virtual Market Market { get; set; }
        public virtual MemberDiscount MemberDiscount { get; set; }
        public virtual MemberSchemeType MemberSchemeType { get; set; }
        public virtual PointType PointType { get; set; }
        public virtual PurchaseTransaction PurchaseTransaction { get; set; }
        public virtual YataRedeemTransaction RedeemTransaction { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual PointTransactionSourceFrom SourceFromNavigation { get; set; }
        public virtual LookupTable StatusType { get; set; }
        public virtual TransactionMethod TransationMethod { get; set; }
        public virtual LookupTable Type { get; set; }
        public virtual AspNetUserDetail UserDetail { get; set; }
        public virtual ICollection<ParkingPayment> ParkingPayment { get; set; }
        public virtual ICollection<PointTransactionCrmSync> PointTransactionCrmSync { get; set; }
        public virtual ICollection<PointTransactionDetail> PointTransactionDetail { get; set; }
        public virtual ICollection<YataPointAdjustmentHistory> YataPointAdjustmentHistory { get; set; }
    }
}
