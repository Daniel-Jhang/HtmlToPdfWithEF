using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class BasicOrMarket
    {
        public BasicOrMarket()
        {
            PriceList = new HashSet<PriceList>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }

        public virtual ICollection<PriceList> PriceList { get; set; }
    }
}
