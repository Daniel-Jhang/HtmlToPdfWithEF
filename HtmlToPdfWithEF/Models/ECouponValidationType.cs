using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ECouponValidationType
    {
        public ECouponValidationType()
        {
            EcouponSetting = new HashSet<EcouponSetting>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }

        public virtual ICollection<EcouponSetting> EcouponSetting { get; set; }
    }
}
