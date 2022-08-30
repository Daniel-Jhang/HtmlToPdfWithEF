using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PhysicalCardDetail
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public Guid? CrmContactId { get; set; }
        public int? CardStatusId { get; set; }
        public bool? IsCardChargeWaived { get; set; }
        public int? WaivedTypeId { get; set; }
        public int? ActivatedInMarketId { get; set; }
        public DateTime? ActivatedOn { get; set; }
        public string ActivatedBy { get; set; }
        public int? DeactivatedInMarketId { get; set; }
        public DateTime? DeactivatedOn { get; set; }
        public string DeactivatedBy { get; set; }
        public int? DeactivateReasonId { get; set; }
        public string Remarks { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? MemberId { get; set; }
        public string CrmId { get; set; }
        public int? DbVersionNumber { get; set; }
        public int? CrmVersionNumber { get; set; }
        public bool? IsCrmUpdated { get; set; }
        public Guid? MemberIdentityKey { get; set; }
        public int? MemberSchemeTypeId { get; set; }
        public Guid? CardTypeId { get; set; }
        public Guid? CccardKindId { get; set; }
        public DateTime? MigrationTime { get; set; }

        public virtual CardStatus CardStatus { get; set; }
        public virtual CardType CardType { get; set; }
        public virtual CccardKind CccardKind { get; set; }
        public virtual Member Member { get; set; }
        public virtual MemberSchemeType MemberSchemeType { get; set; }
    }
}
