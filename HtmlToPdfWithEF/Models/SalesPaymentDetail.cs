using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class SalesPaymentDetail
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public int CurrencyId { get; set; }
        public decimal Amount { get; set; }
        public Guid SalesTransactionId { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual SalesTransaction SalesTransaction { get; set; }
    }
}
