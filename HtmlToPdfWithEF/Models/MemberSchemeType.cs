using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MemberSchemeType
    {
        public MemberSchemeType()
        {
            BenefitDepartment = new HashSet<BenefitDepartment>();
            BuChangePointReason = new HashSet<BuChangePointReason>();
            DummyPointTransaction = new HashSet<DummyPointTransaction>();
            DummyPointTransactionDetail = new HashSet<DummyPointTransactionDetail>();
            DummyPurchaseTransaction = new HashSet<DummyPurchaseTransaction>();
            GamePoint = new HashSet<GamePoint>();
            Market = new HashSet<Market>();
            MemberScheme = new HashSet<MemberScheme>();
            PhysicalCardDetail = new HashSet<PhysicalCardDetail>();
            PointTransaction = new HashSet<PointTransaction>();
            PointTransactionDetail = new HashSet<PointTransactionDetail>();
            PurchaseTransaction = new HashSet<PurchaseTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Crmid { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? VipGroupId { get; set; }
        public string UserNameSuffix { get; set; }
        public bool? IsRedeemSyncToNav { get; set; }
        public int? ReturnOfBenefitId { get; set; }

        public virtual BenefitsMaster ReturnOfBenefit { get; set; }
        public virtual VipGroup VipGroup { get; set; }
        public virtual ICollection<BenefitDepartment> BenefitDepartment { get; set; }
        public virtual ICollection<BuChangePointReason> BuChangePointReason { get; set; }
        public virtual ICollection<DummyPointTransaction> DummyPointTransaction { get; set; }
        public virtual ICollection<DummyPointTransactionDetail> DummyPointTransactionDetail { get; set; }
        public virtual ICollection<DummyPurchaseTransaction> DummyPurchaseTransaction { get; set; }
        public virtual ICollection<GamePoint> GamePoint { get; set; }
        public virtual ICollection<Market> Market { get; set; }
        public virtual ICollection<MemberScheme> MemberScheme { get; set; }
        public virtual ICollection<PhysicalCardDetail> PhysicalCardDetail { get; set; }
        public virtual ICollection<PointTransaction> PointTransaction { get; set; }
        public virtual ICollection<PointTransactionDetail> PointTransactionDetail { get; set; }
        public virtual ICollection<PurchaseTransaction> PurchaseTransaction { get; set; }
    }
}
