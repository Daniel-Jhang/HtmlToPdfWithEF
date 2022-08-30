using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class AddValueTransaction
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public int? MarketId { get; set; }
        public DateTime CreateTime { get; set; }
        public string CscounterUserId { get; set; }
        public string CardNumber { get; set; }
        public decimal Amount { get; set; }
        public string InvoiceNumber { get; set; }

        public virtual Market Market { get; set; }
    }
}
