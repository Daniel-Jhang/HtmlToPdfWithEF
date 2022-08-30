using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class BenefitDepartment
    {
        public BenefitDepartment()
        {
            BenefitsMaster = new HashSet<BenefitsMaster>();
            MarketingCost = new HashSet<MarketingCost>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public int? MemberSchemeTypeId { get; set; }

        public virtual MemberSchemeType MemberSchemeType { get; set; }
        public virtual ICollection<BenefitsMaster> BenefitsMaster { get; set; }
        public virtual ICollection<MarketingCost> MarketingCost { get; set; }
    }
}
