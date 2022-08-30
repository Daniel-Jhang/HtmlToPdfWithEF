using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PriceList
    {
        public PriceList()
        {
            CrossSellingProductPricingOption = new HashSet<CrossSellingProductPricingOption>();
            PriceListItem = new HashSet<PriceListItem>();
            RedeemProduct = new HashSet<RedeemProduct>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? LocationType { get; set; }
        public int? BasicOrMarket { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PriceListPriority { get; set; }
        public int? CurrencyId { get; set; }
        public int? MarketId { get; set; }
        public bool? IsPromotion { get; set; }
        public int? PriceListTypeId { get; set; }
        public int? MemberSchemeTypeId { get; set; }
        public int? MemberSchemeId { get; set; }

        public virtual BasicOrMarket BasicOrMarketNavigation { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Market Market { get; set; }
        public virtual PriceListType PriceListType { get; set; }
        public virtual ICollection<CrossSellingProductPricingOption> CrossSellingProductPricingOption { get; set; }
        public virtual ICollection<PriceListItem> PriceListItem { get; set; }
        public virtual ICollection<RedeemProduct> RedeemProduct { get; set; }
    }
}
