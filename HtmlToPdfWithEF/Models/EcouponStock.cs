using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class EcouponStock
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int RemaininEcouponQuantity { get; set; }
        public Guid EcouponSettingId { get; set; }
        public Guid RedeemProductId { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual EcouponSetting EcouponSetting { get; set; }
        public virtual RedeemProduct RedeemProduct { get; set; }
    }
}
