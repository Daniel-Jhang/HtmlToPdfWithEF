using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataList
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public string Purpose { get; set; }
        public int? CreatedFromCode { get; set; }
        public string Source { get; set; }
        public Guid? TransactionCurrencyId { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? LastUsedOn { get; set; }
        public bool? LockStatus { get; set; }
        public string Description { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
    }
}
