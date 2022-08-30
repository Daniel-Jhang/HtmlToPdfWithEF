using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class TempMarketingTransactionReprot
    {
        public int SqlIdd { get; set; }
        public Guid Id { get; set; }
        public Guid? UserDetailId { get; set; }
        public Guid? PurchaseTransactionId { get; set; }
        public int? PurchaseTransactionMemberSchemeTypeId { get; set; }
        public decimal? PurchaseTransactionTransactionAmount { get; set; }
        public DateTime? PurchaseTransactionTransactionDateTime { get; set; }
        public int? ShopId { get; set; }
        public int? ShopFloorId { get; set; }
        public int? ShopShopCategory { get; set; }
    }
}
