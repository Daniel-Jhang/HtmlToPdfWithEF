using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RedeemProduct
    {
        public RedeemProduct()
        {
            CrossSellingProductMainRedeemProduct = new HashSet<CrossSellingProduct>();
            CrossSellingProductRelatedRedeemProduct = new HashSet<CrossSellingProduct>();
            EcouponRecord = new HashSet<EcouponRecord>();
            EcouponSetting = new HashSet<EcouponSetting>();
            EcouponStock = new HashSet<EcouponStock>();
            PriceListItem = new HashSet<PriceListItem>();
            RedeemProductAssociationBoundleRedeemProduct = new HashSet<RedeemProductAssociation>();
            RedeemProductAssociationRedeemPorduct = new HashSet<RedeemProductAssociation>();
            RedeemProductStock = new HashSet<RedeemProductStock>();
            RedeemTransactionDetail = new HashSet<RedeemTransactionDetail>();
            SalesTransactionDetail = new HashSet<SalesTransactionDetail>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ProductCrmDisplayName { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string Description { get; set; }
        public int? UniGroupId { get; set; }
        public Guid? DefaultPriceListId { get; set; }
        public int? DefaultUnitId { get; set; }
        public DateTime? CreateOn { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string UnitName { get; set; }
        public string UnitCrmId { get; set; }
        public int? StatuscodeOptionValue { get; set; }
        public Guid? NavItemId { get; set; }
        public int? RedeemProductStructureId { get; set; }
        public decimal? SafetyStockQuantity { get; set; }
        public bool? IsPreOrderUsed { get; set; }
        public string Code { get; set; }
        public string PoUnitName { get; set; }
        public decimal? ConversionQuantity { get; set; }
        public string EnglishName { get; set; }
        public string EnglishDescription { get; set; }
        public string ImageUri { get; set; }
        public int? RedeemTypeId { get; set; }
        public decimal? MaxPurchaseQuantityPerUser { get; set; }
        public string Upc { get; set; }
        public bool? IsExcludePointCalculate { get; set; }

        public virtual PriceList DefaultPriceList { get; set; }
        public virtual Unit DefaultUnit { get; set; }
        public virtual RedeemProductStructure RedeemProductStructure { get; set; }
        public virtual RedeemType RedeemType { get; set; }
        public virtual UnitGroup UniGroup { get; set; }
        public virtual ICollection<CrossSellingProduct> CrossSellingProductMainRedeemProduct { get; set; }
        public virtual ICollection<CrossSellingProduct> CrossSellingProductRelatedRedeemProduct { get; set; }
        public virtual ICollection<EcouponRecord> EcouponRecord { get; set; }
        public virtual ICollection<EcouponSetting> EcouponSetting { get; set; }
        public virtual ICollection<EcouponStock> EcouponStock { get; set; }
        public virtual ICollection<PriceListItem> PriceListItem { get; set; }
        public virtual ICollection<RedeemProductAssociation> RedeemProductAssociationBoundleRedeemProduct { get; set; }
        public virtual ICollection<RedeemProductAssociation> RedeemProductAssociationRedeemPorduct { get; set; }
        public virtual ICollection<RedeemProductStock> RedeemProductStock { get; set; }
        public virtual ICollection<RedeemTransactionDetail> RedeemTransactionDetail { get; set; }
        public virtual ICollection<SalesTransactionDetail> SalesTransactionDetail { get; set; }
    }
}
