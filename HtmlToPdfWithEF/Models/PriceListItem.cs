using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PriceListItem
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? PriceListId { get; set; }
        public Guid? RedeemProductId { get; set; }
        public int? UnitId { get; set; }
        public string KeyField { get; set; }
        public decimal? Price { get; set; }
        public decimal? Point { get; set; }
        public DateTime? CreateOn { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string UnitName { get; set; }
        public string UnitCrmId { get; set; }
        public decimal? OriginalPrice { get; set; }
        public decimal? OriginalPoint { get; set; }

        public virtual PriceList PriceList { get; set; }
        public virtual RedeemProduct RedeemProduct { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
