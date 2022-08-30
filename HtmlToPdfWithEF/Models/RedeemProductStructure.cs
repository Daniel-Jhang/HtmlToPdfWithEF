using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RedeemProductStructure
    {
        public RedeemProductStructure()
        {
            RedeemProduct = new HashSet<RedeemProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }

        public virtual ICollection<RedeemProduct> RedeemProduct { get; set; }
    }
}
