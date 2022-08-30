using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class AspnetUserDetailMarketingOption
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public Guid AspnetUserDetailId { get; set; }
        public Guid MarketingOptionId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUserDetail AspnetUserDetail { get; set; }
        public virtual MarketingOption MarketingOption { get; set; }
    }
}
