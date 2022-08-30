using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class DummyPurchaseTransaction
    {
        public DummyPurchaseTransaction()
        {
            DummyPointTransaction = new HashSet<DummyPointTransaction>();
            DummyPurchaseTransactionDetail = new HashSet<DummyPurchaseTransactionDetail>();
            DummyPurchaseTransactionLineList = new HashSet<DummyPurchaseTransactionLineList>();
            DummyPurchaseTransactionPaymentDetail = new HashSet<DummyPurchaseTransactionPaymentDetail>();
            DummyPurchaseTransactionProductCategory = new HashSet<DummyPurchaseTransactionProductCategory>();
            InverseModifyPurchaseTransaction = new HashSet<DummyPurchaseTransaction>();
            InverseOriginalPurchaseTransaction = new HashSet<DummyPurchaseTransaction>();
        }

        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string InvoiceNumber { get; set; }
        public string PhoneNumber { get; set; }
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
        public Guid? OriginalPurchaseTransactionId { get; set; }
        public int? HistoryTypeId { get; set; }

        public virtual YataPointHistoryType HistoryType { get; set; }
        public virtual Market Market { get; set; }
        public virtual MemberSchemeType MemberSchemeType { get; set; }
        public virtual DummyPurchaseTransaction ModifyPurchaseTransaction { get; set; }
        public virtual DummyPurchaseTransaction OriginalPurchaseTransaction { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual LookupTable Type { get; set; }
        public virtual ICollection<DummyPointTransaction> DummyPointTransaction { get; set; }
        public virtual ICollection<DummyPurchaseTransactionDetail> DummyPurchaseTransactionDetail { get; set; }
        public virtual ICollection<DummyPurchaseTransactionLineList> DummyPurchaseTransactionLineList { get; set; }
        public virtual ICollection<DummyPurchaseTransactionPaymentDetail> DummyPurchaseTransactionPaymentDetail { get; set; }
        public virtual ICollection<DummyPurchaseTransactionProductCategory> DummyPurchaseTransactionProductCategory { get; set; }
        public virtual ICollection<DummyPurchaseTransaction> InverseModifyPurchaseTransaction { get; set; }
        public virtual ICollection<DummyPurchaseTransaction> InverseOriginalPurchaseTransaction { get; set; }
    }
}
