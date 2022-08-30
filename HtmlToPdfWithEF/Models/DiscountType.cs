using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class DiscountType
    {
        public DiscountType()
        {
            RedeemDiscountMaster = new HashSet<RedeemDiscountMaster>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<RedeemDiscountMaster> RedeemDiscountMaster { get; set; }
    }
}
