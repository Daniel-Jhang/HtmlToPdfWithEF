using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class CccardKind
    {
        public CccardKind()
        {
            BenefitsCccardKind = new HashSet<BenefitsCccardKind>();
            PhysicalCardDetail = new HashSet<PhysicalCardDetail>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual ICollection<BenefitsCccardKind> BenefitsCccardKind { get; set; }
        public virtual ICollection<PhysicalCardDetail> PhysicalCardDetail { get; set; }
    }
}
