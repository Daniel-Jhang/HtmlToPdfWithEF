using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class CrossSellingProduct
    {
        public CrossSellingProduct()
        {
            CrossSellingProductPricingOption = new HashSet<CrossSellingProductPricingOption>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? MainRedeemProductId { get; set; }
        public Guid? RelatedRedeemProductId { get; set; }
        public string KeyField { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual RedeemProduct MainRedeemProduct { get; set; }
        public virtual RedeemProduct RelatedRedeemProduct { get; set; }
        public virtual ICollection<CrossSellingProductPricingOption> CrossSellingProductPricingOption { get; set; }
    }
}
