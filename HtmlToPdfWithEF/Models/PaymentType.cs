using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            BenefitsMaster = new HashSet<BenefitsMaster>();
            DummyPurchaseTransactionLineList = new HashSet<DummyPurchaseTransactionLineList>();
            DummyPurchaseTransactionPaymentDetail = new HashSet<DummyPurchaseTransactionPaymentDetail>();
            PurchaseTransactionLineList = new HashSet<PurchaseTransactionLineList>();
            PurchaseTransactionPaymentDetail = new HashSet<PurchaseTransactionPaymentDetail>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? PayKindId { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public int? Priority { get; set; }
        public bool? ThePointExclude { get; set; }

        public virtual PayKind PayKind { get; set; }
        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
        public virtual ICollection<DummyPurchaseTransactionLineList> DummyPurchaseTransactionLineList { get; set; }
        public virtual ICollection<DummyPurchaseTransactionPaymentDetail> DummyPurchaseTransactionPaymentDetail { get; set; }
        public virtual ICollection<PurchaseTransactionLineList> PurchaseTransactionLineList { get; set; }
        public virtual ICollection<PurchaseTransactionPaymentDetail> PurchaseTransactionPaymentDetail { get; set; }
    }
}
