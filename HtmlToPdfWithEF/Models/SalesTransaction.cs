using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class SalesTransaction
    {
        public SalesTransaction()
        {
            SalesPaymentDetail = new HashSet<SalesPaymentDetail>();
            SalesTransactionDetail = new HashSet<SalesTransactionDetail>();
        }

        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public string InvoiceNumber { get; set; }
        public int MarketId { get; set; }
        public int ShopId { get; set; }
        public int CurrencyId { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public decimal TotalTransactionAmount { get; set; }
        public bool IsSyncToCrm { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual Market Market { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual ICollection<SalesPaymentDetail> SalesPaymentDetail { get; set; }
        public virtual ICollection<SalesTransactionDetail> SalesTransactionDetail { get; set; }
    }
}
