using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MemberTierLog
    {
        public int SqlId { get; set; }
        public Guid? UserDetailId { get; set; }
        public decimal? AccumulatedAmount { get; set; }
        public DateTime? UpgradeDateTime { get; set; }
        public DateTime? ResetDateTime { get; set; }
        public DateTime? Vipperiod { get; set; }
    }
}
