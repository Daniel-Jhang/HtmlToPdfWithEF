using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class EcouponRecord
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string EcouponCode { get; set; }
        public DateTime? RedeemDate { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime? UsedDate { get; set; }
        public decimal? TransactionAmount { get; set; }
        public decimal? UsedValue { get; set; }
        public decimal? RealPay { get; set; }
        public string N5OutTradeNo { get; set; }
        public string PosId { get; set; }
        public Guid? PurchaseTransactionId { get; set; }
        public Guid? EcouponSettingId { get; set; }
        public Guid RedeemProductId { get; set; }
        public Guid? UserDetailId { get; set; }
        public int? EcouponStatusId { get; set; }
        public int? RedeemPlatformId { get; set; }
        public int? CurrencyId { get; set; }
        public Guid? OriEcouponRecordId { get; set; }
        public string QrcodeUrl { get; set; }
        public byte[] RowVersion { get; set; }
        public Guid? CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ImportSequenceNumber { get; set; }
        public DateTime? UpdateTimeStamp { get; set; }
        public DateTime CreateDateTime { get; set; }
        public Guid? RedeemTransactionDetailId { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual EcouponSetting EcouponSetting { get; set; }
        public virtual YataECouponStatus EcouponStatus { get; set; }
        public virtual Pos Pos { get; set; }
        public virtual PurchaseTransaction PurchaseTransaction { get; set; }
        public virtual RedeemtionType RedeemPlatform { get; set; }
        public virtual RedeemProduct RedeemProduct { get; set; }
        public virtual RedeemTransactionDetail RedeemTransactionDetail { get; set; }
        public virtual AspNetUserDetail UserDetail { get; set; }
    }
}
