using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class BenefitsSalesProductBrand
    {
        public int Id { get; set; }
        public int BenefitsMasterId { get; set; }
        public Guid? BrandId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
