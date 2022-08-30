using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class CrossSellingProductPricingOption
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string KeyField { get; set; }
        public Guid? PriceList { get; set; }
        public decimal? Price { get; set; }
        public decimal? Point { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public Guid? CrossSellingProductPricingId { get; set; }

        public virtual CrossSellingProduct CrossSellingProductPricing { get; set; }
        public virtual PriceList PriceListNavigation { get; set; }
    }
}
