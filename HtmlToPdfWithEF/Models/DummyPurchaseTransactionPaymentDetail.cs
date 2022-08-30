using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class DummyPurchaseTransactionPaymentDetail
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid PurchaseTransactionId { get; set; }
        public Guid PaymentTypeId { get; set; }
        public decimal Amount { get; set; }
        public Guid? ECouponRecordId { get; set; }

        public virtual PaymentType PaymentType { get; set; }
        public virtual DummyPurchaseTransaction PurchaseTransaction { get; set; }
    }
}
