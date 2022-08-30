using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Member
    {
        public Member()
        {
            PhysicalCardDetail = new HashSet<PhysicalCardDetail>();
            RedeemTransaction = new HashSet<RedeemTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Guid UserDetailId { get; set; }
        public int? MemberSchemeId { get; set; }
        public bool? IsEnable { get; set; }
        public DateTime? ActivationDate { get; set; }
        public string MembershipId { get; set; }
        public int? MemberStatusReasonId { get; set; }
        public int? MemberAcquisition { get; set; }
        public string CrmId { get; set; }
        public int? CrmVersionNumber { get; set; }
        public int? DbVersionNumber { get; set; }
        public bool? IsCrmUpdated { get; set; }
        public bool? IsDeleted { get; set; }
        public string FacebookAccessToken { get; set; }
        public string FacebookUserId { get; set; }
        public int? SendMemberToCrm { get; set; }
        public DateTime? RenewalDateTime { get; set; }
        public DateTime? RenewalFirstTransactionDateTime { get; set; }
        public DateTime? UpgradeFirstTransactionDateTime { get; set; }
        public Guid? IdentityKey { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string TerminationSignatureUrlPath { get; set; }
        public bool? IsAgreeTermination { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string ReasonOfTermination { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string SubscriptionRefId { get; set; }
        public DateTime? MigrationTime { get; set; }
        public int? Pgid { get; set; }
        public string Xmin { get; set; }

        public virtual Channel MemberAcquisitionNavigation { get; set; }
        public virtual MemberScheme MemberScheme { get; set; }
        public virtual MemberStatusReason MemberStatusReason { get; set; }
        public virtual AspNetUserDetail UserDetail { get; set; }
        public virtual ICollection<PhysicalCardDetail> PhysicalCardDetail { get; set; }
        public virtual ICollection<RedeemTransaction> RedeemTransaction { get; set; }
    }
}
