using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MemberRegistrationBooth
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsCsCounter { get; set; }
        public int? LocationTypeId { get; set; }
        public int? MarketId { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Market Market { get; set; }
    }
}
