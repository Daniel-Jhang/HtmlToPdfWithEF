using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MarketingCostTag
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public Guid? TagId { get; set; }
        public Guid? MarketingCostId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual MarketingCost MarketingCost { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
