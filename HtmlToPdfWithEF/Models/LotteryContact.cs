using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class LotteryContact
    {
        public LotteryContact()
        {
            LotteryContactPurchaseTransaction = new HashSet<LotteryContactPurchaseTransaction>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid LotteryId { get; set; }
        public Guid? AspNetUserDetailId { get; set; }
        public int? WinningAwardPeriod { get; set; }
        public Guid? WinningAwardId { get; set; }
        public Guid? RemoveAwardId { get; set; }
        public DateTime? WinTime { get; set; }
        public DateTime? RemoveTime { get; set; }
        public bool? ReceiveAward { get; set; }
        public bool IsEnable { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public DateTime? ReturnTime { get; set; }

        public virtual AspNetUserDetail AspNetUserDetail { get; set; }
        public virtual Lottery Lottery { get; set; }
        public virtual LotteryAward RemoveAward { get; set; }
        public virtual LotteryAward WinningAward { get; set; }
        public virtual ICollection<LotteryContactPurchaseTransaction> LotteryContactPurchaseTransaction { get; set; }
    }
}
