using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MembershipExpirationAndCumulativePeriod
    {
        public MembershipExpirationAndCumulativePeriod()
        {
            MemberSchemeMembershipExpiration = new HashSet<MemberScheme>();
            MemberSchemeSalesAmountCumulativePeriodRenewal = new HashSet<MemberScheme>();
            MemberSchemeSalesAmountCumulativePeriodUpgrade = new HashSet<MemberScheme>();
            VipGroup = new HashSet<VipGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }

        public virtual ICollection<MemberScheme> MemberSchemeMembershipExpiration { get; set; }
        public virtual ICollection<MemberScheme> MemberSchemeSalesAmountCumulativePeriodRenewal { get; set; }
        public virtual ICollection<MemberScheme> MemberSchemeSalesAmountCumulativePeriodUpgrade { get; set; }
        public virtual ICollection<VipGroup> VipGroup { get; set; }
    }
}
