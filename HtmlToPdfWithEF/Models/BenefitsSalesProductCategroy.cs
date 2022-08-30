using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class BenefitsSalesProductCategroy
    {
        public int Id { get; set; }
        public int BenefitsMasterId { get; set; }
        public Guid? SalesProductCategoryId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual BenefitsMaster BenefitsMaster { get; set; }
    }
}
