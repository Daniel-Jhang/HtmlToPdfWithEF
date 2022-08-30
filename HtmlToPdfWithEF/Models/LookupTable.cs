using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class LookupTable
    {
        public LookupTable()
        {
            DoubleBenefit = new HashSet<DoubleBenefit>();
            DummyPointTransactionStatusType = new HashSet<DummyPointTransaction>();
            DummyPointTransactionType = new HashSet<DummyPointTransaction>();
            DummyPurchaseTransaction = new HashSet<DummyPurchaseTransaction>();
            PointTransactionStatusType = new HashSet<PointTransaction>();
            PointTransactionType = new HashSet<PointTransaction>();
            PurchaseTransaction = new HashSet<PurchaseTransaction>();
            RedeemTransactionStatus = new HashSet<RedeemTransaction>();
            RedeemTransactionType = new HashSet<RedeemTransaction>();
            TransactionStatus = new HashSet<TransactionStatus>();
            YataRedeemTransaction = new HashSet<YataRedeemTransaction>();
        }

        public int Id { get; set; }
        public string TypeCode { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DoubleBenefit> DoubleBenefit { get; set; }
        public virtual ICollection<DummyPointTransaction> DummyPointTransactionStatusType { get; set; }
        public virtual ICollection<DummyPointTransaction> DummyPointTransactionType { get; set; }
        public virtual ICollection<DummyPurchaseTransaction> DummyPurchaseTransaction { get; set; }
        public virtual ICollection<PointTransaction> PointTransactionStatusType { get; set; }
        public virtual ICollection<PointTransaction> PointTransactionType { get; set; }
        public virtual ICollection<PurchaseTransaction> PurchaseTransaction { get; set; }
        public virtual ICollection<RedeemTransaction> RedeemTransactionStatus { get; set; }
        public virtual ICollection<RedeemTransaction> RedeemTransactionType { get; set; }
        public virtual ICollection<TransactionStatus> TransactionStatus { get; set; }
        public virtual ICollection<YataRedeemTransaction> YataRedeemTransaction { get; set; }
    }
}
