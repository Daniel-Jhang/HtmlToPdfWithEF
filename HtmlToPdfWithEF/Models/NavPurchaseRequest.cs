using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class NavPurchaseRequest
    {
        public NavPurchaseRequest()
        {
            RedeemTransaction = new HashSet<RedeemTransaction>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string NavPurchaseRequestNo { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int MarketId { get; set; }
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public bool IsSyncToNav { get; set; }
        public bool IsPreOrderRequest { get; set; }
        public bool IsPreOrderAlreadyPickedUp { get; set; }
        public bool IsSyncPickUp { get; set; }
        public string PreOrderQrcodeUrl { get; set; }

        public virtual Market Market { get; set; }
        public virtual ICollection<RedeemTransaction> RedeemTransaction { get; set; }
    }
}
