using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class BenefitsMarket
    {
        public Guid Id { get; set; }
        public int BenefitsMasterId { get; set; }
        public int MarketId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual BenefitsMaster BenefitsMaster { get; set; }
        public virtual Market Market { get; set; }
    }
}
