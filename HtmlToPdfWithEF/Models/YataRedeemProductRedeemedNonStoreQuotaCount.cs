using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataRedeemProductRedeemedNonStoreQuotaCount
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid RedeemProductMasterId { get; set; }
        public int RedeemedCount { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
