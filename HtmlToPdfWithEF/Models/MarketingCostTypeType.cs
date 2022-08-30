using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MarketingCostTypeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
