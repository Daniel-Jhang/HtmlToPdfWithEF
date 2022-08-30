using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class BenefitsCccardKind
    {
        public Guid Id { get; set; }
        public int BenefitsMasterId { get; set; }
        public Guid CccardKindId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual BenefitsMaster BenefitsMaster { get; set; }
        public virtual CccardKind CccardKind { get; set; }
    }
}
