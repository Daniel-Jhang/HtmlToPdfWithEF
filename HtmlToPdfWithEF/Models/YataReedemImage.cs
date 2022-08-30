using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataReedemImage
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string Name { get; set; }
        public Guid? ECouponSettingId { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public int? Sequence { get; set; }
        public int? Language { get; set; }

        public virtual YataECouponSetting ECouponSetting { get; set; }
    }
}
