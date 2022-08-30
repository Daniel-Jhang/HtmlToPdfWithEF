using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RedeemDiscountMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsByPrice { get; set; }
        public bool? IsByPercentage { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }
        public int? DiscountTypeId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual DiscountType DiscountType { get; set; }
    }
}
