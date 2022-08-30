using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class RedeemType
    {
        public RedeemType()
        {
            RedeemProduct = new HashSet<RedeemProduct>();
            RedeemTransaction = new HashSet<RedeemTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }

        public virtual ICollection<RedeemProduct> RedeemProduct { get; set; }
        public virtual ICollection<RedeemTransaction> RedeemTransaction { get; set; }
    }
}
