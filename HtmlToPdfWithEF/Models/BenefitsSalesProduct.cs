using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class BenefitsSalesProduct
    {
        public int Id { get; set; }
        public Guid SalesProductMasterId { get; set; }
        public int BenefitsMasterId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual BenefitsMaster BenefitsMaster { get; set; }
        public virtual YataSalesProductMaster SalesProductMaster { get; set; }
    }
}
