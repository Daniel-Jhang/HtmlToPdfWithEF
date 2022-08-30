using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ConfigurationCentral
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Settingcode { get; set; }
        public decimal? ValueMoney { get; set; }
        public DateTime? ValueDateTime { get; set; }
        public int? ValueInt { get; set; }
        public decimal? ValueDecimal { get; set; }
        public decimal? ValueMoneyBase { get; set; }
        public string ValueText { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? TypeOfField { get; set; }
    }
}
