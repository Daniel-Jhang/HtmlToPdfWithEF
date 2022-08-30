using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Lottery
    {
        public Lottery()
        {
            LotteryAward = new HashSet<LotteryAward>();
            LotteryContact = new HashSet<LotteryContact>();
            LotteryMarket = new HashSet<LotteryMarket>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? LotteryTime { get; set; }
        public DateTime? RegisterStart { get; set; }
        public DateTime? RegisterEnd { get; set; }
        public decimal? SalesAmountLimit { get; set; }
        public decimal? PointRequired { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsPeriodicLottery { get; set; }
        public int? NumberOfUnits { get; set; }
        public int? PeriodUnit { get; set; }
        public int? CurrentLotteryProgress { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? NumberOfLottery { get; set; }
        public int? MemberBenefitId { get; set; }
        public string GetRewardLocation { get; set; }
        public DateTime? GetRewardDeadline { get; set; }
        public string AwardNote { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<LotteryAward> LotteryAward { get; set; }
        public virtual ICollection<LotteryContact> LotteryContact { get; set; }
        public virtual ICollection<LotteryMarket> LotteryMarket { get; set; }
    }
}
