using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class LotteryAward
    {
        public LotteryAward()
        {
            LotteryContactRemoveAward = new HashSet<LotteryContact>();
            LotteryContactWinningAward = new HashSet<LotteryContact>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public int? Seqnumber { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public Guid? LotteryId { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Lottery Lottery { get; set; }
        public virtual ICollection<LotteryContact> LotteryContactRemoveAward { get; set; }
        public virtual ICollection<LotteryContact> LotteryContactWinningAward { get; set; }
    }
}
