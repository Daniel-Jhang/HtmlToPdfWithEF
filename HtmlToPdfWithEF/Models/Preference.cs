using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Preference
    {
        public Preference()
        {
            MarketingOption = new HashSet<MarketingOption>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }

        public virtual ICollection<MarketingOption> MarketingOption { get; set; }
    }
}
