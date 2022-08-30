using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Unit
    {
        public Unit()
        {
            PriceListItem = new HashSet<PriceListItem>();
            RedeemProduct = new HashSet<RedeemProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual ICollection<PriceListItem> PriceListItem { get; set; }
        public virtual ICollection<RedeemProduct> RedeemProduct { get; set; }
    }
}
