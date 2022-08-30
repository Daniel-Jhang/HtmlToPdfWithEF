using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataSalesProductMaster
    {
        public YataSalesProductMaster()
        {
            BenefitsSalesProduct = new HashSet<BenefitsSalesProduct>();
            DummyPointTransactionDetail = new HashSet<DummyPointTransactionDetail>();
            DummyPurchaseTransactionDetail = new HashSet<DummyPurchaseTransactionDetail>();
            DummyPurchaseTransactionLineList = new HashSet<DummyPurchaseTransactionLineList>();
            PurchaseTransactionDetail = new HashSet<PurchaseTransactionDetail>();
            PurchaseTransactionLineList = new HashSet<PurchaseTransactionLineList>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string Name { get; set; }
        public Guid? BrandId { get; set; }
        public string Color { get; set; }
        public Guid? Division { get; set; }
        public Guid? Category { get; set; }
        public Guid? SubCategory { get; set; }
        public bool? ExclusionItem { get; set; }
        public string ItemCode { get; set; }
        public string ProductDescription { get; set; }
        public string Size { get; set; }
        public string Upc { get; set; }
        public string ItemUpc { get; set; }
        public Guid? Department { get; set; }
        public Guid? Company { get; set; }

        public virtual YataSalesProductBrand Brand { get; set; }
        public virtual ICollection<BenefitsSalesProduct> BenefitsSalesProduct { get; set; }
        public virtual ICollection<DummyPointTransactionDetail> DummyPointTransactionDetail { get; set; }
        public virtual ICollection<DummyPurchaseTransactionDetail> DummyPurchaseTransactionDetail { get; set; }
        public virtual ICollection<DummyPurchaseTransactionLineList> DummyPurchaseTransactionLineList { get; set; }
        public virtual ICollection<PurchaseTransactionDetail> PurchaseTransactionDetail { get; set; }
        public virtual ICollection<PurchaseTransactionLineList> PurchaseTransactionLineList { get; set; }
    }
}
