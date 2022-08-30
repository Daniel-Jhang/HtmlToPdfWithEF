using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MarketingCost
    {
        public MarketingCost()
        {
            MarketingCostBenefitMaster = new HashSet<MarketingCostBenefitMaster>();
            MarketingCostTag = new HashSet<MarketingCostTag>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? BenefitDepartmentId { get; set; }
        public int? ShopId { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndDay { get; set; }
        public int? MarketingCostTypeId { get; set; }
        public Guid? ActivityId { get; set; }
        public int? TaCount { get; set; }
        public int? AddressDistinctCount { get; set; }
        public Guid? CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? FlowId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual BenefitDepartment BenefitDepartment { get; set; }
        public virtual Flow Flow { get; set; }
        public virtual MarketingCostType MarketingCostType { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual ICollection<MarketingCostBenefitMaster> MarketingCostBenefitMaster { get; set; }
        public virtual ICollection<MarketingCostTag> MarketingCostTag { get; set; }
    }
}
