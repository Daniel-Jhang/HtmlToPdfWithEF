using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class WaivedType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? WaivedAmount { get; set; }
        public DateTime? ExpiredOn { get; set; }
        public int? StandardServiceChargeId { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
