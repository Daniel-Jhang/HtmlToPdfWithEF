using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class CardStatus
    {
        public CardStatus()
        {
            PhysicalCardDetail = new HashSet<PhysicalCardDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<PhysicalCardDetail> PhysicalCardDetail { get; set; }
    }
}
