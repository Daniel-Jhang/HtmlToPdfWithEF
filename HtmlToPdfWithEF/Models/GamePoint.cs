using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class GamePoint
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid UserDetailId { get; set; }
        public DateTime ValidTime { get; set; }
        public int Available { get; set; }
        public bool Used { get; set; }
        public int? Status { get; set; }
        public Guid? GameId { get; set; }
        public int? MemberSchemeTypeId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UsedTime { get; set; }
        public DateTime ExpiryDate { get; set; }
        public byte[] Rowversion { get; set; }
        public Guid? PurchaseTransactionId { get; set; }
        public int? BenefitsMasterId { get; set; }

        public virtual MemberSchemeType MemberSchemeType { get; set; }
        public virtual PurchaseTransaction PurchaseTransaction { get; set; }
        public virtual AspNetUserDetail UserDetail { get; set; }
    }
}
