using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class LotteryContactPurchaseTransaction
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? AspNetUserDetailId { get; set; }
        public Guid? PurchaseTransactionId { get; set; }
        public string ReceiptNumber { get; set; }
        public Guid LotteryContactId { get; set; }
        public decimal TicketAmount { get; set; }
        public bool? IsReturn { get; set; }
        public DateTime? SysCreateTime { get; set; }

        public virtual AspNetUserDetail AspNetUserDetail { get; set; }
        public virtual LotteryContact LotteryContact { get; set; }
        public virtual PurchaseTransaction PurchaseTransaction { get; set; }
    }
}
