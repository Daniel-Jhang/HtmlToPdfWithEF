using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Shop
    {
        public Shop()
        {
            BenefitsShop = new HashSet<BenefitsShop>();
            DummyPointTransaction = new HashSet<DummyPointTransaction>();
            DummyPurchaseTransaction = new HashSet<DummyPurchaseTransaction>();
            MarketingCost = new HashSet<MarketingCost>();
            PointTransaction = new HashSet<PointTransaction>();
            Pos = new HashSet<Pos>();
            PurchaseTransaction = new HashSet<PurchaseTransaction>();
            ReferralCode = new HashSet<ReferralCode>();
            SalesTransaction = new HashSet<SalesTransaction>();
            SalesTransactionDetail = new HashSet<SalesTransactionDetail>();
            ShopSharePoint = new HashSet<ShopSharePoint>();
            Tag = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? ShopCategoryId { get; set; }
        public int? MarketId { get; set; }
        public int? LocationTypeId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? FloorId { get; set; }
        public DateTime? MigrationTime { get; set; }

        public virtual Floor Floor { get; set; }
        public virtual LocationType LocationType { get; set; }
        public virtual Market Market { get; set; }
        public virtual ShopCategory ShopCategory { get; set; }
        public virtual ICollection<BenefitsShop> BenefitsShop { get; set; }
        public virtual ICollection<DummyPointTransaction> DummyPointTransaction { get; set; }
        public virtual ICollection<DummyPurchaseTransaction> DummyPurchaseTransaction { get; set; }
        public virtual ICollection<MarketingCost> MarketingCost { get; set; }
        public virtual ICollection<PointTransaction> PointTransaction { get; set; }
        public virtual ICollection<Pos> Pos { get; set; }
        public virtual ICollection<PurchaseTransaction> PurchaseTransaction { get; set; }
        public virtual ICollection<ReferralCode> ReferralCode { get; set; }
        public virtual ICollection<SalesTransaction> SalesTransaction { get; set; }
        public virtual ICollection<SalesTransactionDetail> SalesTransactionDetail { get; set; }
        public virtual ICollection<ShopSharePoint> ShopSharePoint { get; set; }
        public virtual ICollection<Tag> Tag { get; set; }
    }
}
