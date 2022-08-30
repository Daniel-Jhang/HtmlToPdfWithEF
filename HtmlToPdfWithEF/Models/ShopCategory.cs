using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ShopCategory
    {
        public ShopCategory()
        {
            BenefitsShopCategory = new HashSet<BenefitsShopCategory>();
            Shop = new HashSet<Shop>();
            Tag = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<BenefitsShopCategory> BenefitsShopCategory { get; set; }
        public virtual ICollection<Shop> Shop { get; set; }
        public virtual ICollection<Tag> Tag { get; set; }
    }
}
