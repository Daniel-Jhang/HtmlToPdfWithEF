using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MarketingCostBenefitMaster
    {
        public int Id { get; set; }
        public Guid MarketingCostId { get; set; }
        public int BenefitsMasterId { get; set; }

        public virtual BenefitsMaster BenefitsMaster { get; set; }
        public virtual MarketingCost MarketingCost { get; set; }
    }
}
