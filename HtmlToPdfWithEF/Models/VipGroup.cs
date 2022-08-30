using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class VipGroup
    {
        public VipGroup()
        {
            MemberSchemeType = new HashSet<MemberSchemeType>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? MembershipExpirationId { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual MembershipExpirationAndCumulativePeriod MembershipExpiration { get; set; }
        public virtual ICollection<MemberSchemeType> MemberSchemeType { get; set; }
    }
}
