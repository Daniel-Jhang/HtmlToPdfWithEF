using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class EcouponUsedPlatform
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSet { get; set; }
    }
}
