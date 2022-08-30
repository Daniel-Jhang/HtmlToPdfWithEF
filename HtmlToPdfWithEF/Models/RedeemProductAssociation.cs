using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RedeemProductAssociation
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? BoundleRedeemProductId { get; set; }
        public Guid? RedeemPorductId { get; set; }
        public decimal? Quantity { get; set; }
        public bool? Required { get; set; }
        public Guid? CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual RedeemProduct BoundleRedeemProduct { get; set; }
        public virtual RedeemProduct RedeemPorduct { get; set; }
    }
}
