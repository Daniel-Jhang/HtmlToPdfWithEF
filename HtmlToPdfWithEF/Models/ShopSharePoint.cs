using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ShopSharePoint
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? BenefitsMasterId { get; set; }
        public int? ShopId { get; set; }
        public decimal? SharePoint { get; set; }
        public DateTime? RslModifiedTime { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual BenefitsMaster BenefitsMaster { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
