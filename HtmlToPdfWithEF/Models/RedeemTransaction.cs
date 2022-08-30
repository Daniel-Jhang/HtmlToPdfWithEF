using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RedeemTransaction
    {
        public RedeemTransaction()
        {
            DummyPointTransaction = new HashSet<DummyPointTransaction>();
            RedeemPaymentDetail = new HashSet<RedeemPaymentDetail>();
            RedeemTransactionDetail = new HashSet<RedeemTransactionDetail>();
        }

        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public int? TypeId { get; set; }
        public int? StatusId { get; set; }
        public int? FromMarketId { get; set; }
        public int? ToMarketId { get; set; }
        public DateTime CreateTime { get; set; }
        public string InvoiceNumber { get; set; }
        public int? RedemtionTypeId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? AmountDiscount { get; set; }
        public decimal? FinnalAmount { get; set; }
        public decimal? TotalPoint { get; set; }
        public decimal? PointDiscount { get; set; }
        public decimal? PointRedeemed { get; set; }
        public string DiscountReason { get; set; }
        public int? MemberId { get; set; }
        public string CscounterUserId { get; set; }
        public string CsCounterEamil { get; set; }
        public bool IsSyncToCrm { get; set; }
        public Guid? NavPurchaseRequestId { get; set; }
        public int? RedeemTypeId { get; set; }
        public bool? IsPickUp { get; set; }
        public DateTime? PickUpDatetime { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual Market FromMarket { get; set; }
        public virtual Member Member { get; set; }
        public virtual NavPurchaseRequest NavPurchaseRequest { get; set; }
        public virtual RedeemType RedeemType { get; set; }
        public virtual RedeemtionType RedemtionType { get; set; }
        public virtual LookupTable Status { get; set; }
        public virtual Market ToMarket { get; set; }
        public virtual LookupTable Type { get; set; }
        public virtual ICollection<DummyPointTransaction> DummyPointTransaction { get; set; }
        public virtual ICollection<RedeemPaymentDetail> RedeemPaymentDetail { get; set; }
        public virtual ICollection<RedeemTransactionDetail> RedeemTransactionDetail { get; set; }
    }
}
