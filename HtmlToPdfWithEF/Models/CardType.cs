using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class CardType
    {
        public CardType()
        {
            PhysicalCardDetail = new HashSet<PhysicalCardDetail>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual ICollection<PhysicalCardDetail> PhysicalCardDetail { get; set; }
    }
}
