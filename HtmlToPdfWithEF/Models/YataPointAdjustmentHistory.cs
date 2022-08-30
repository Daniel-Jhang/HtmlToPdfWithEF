using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataPointAdjustmentHistory
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? CrmId { get; set; }
        public Guid? UserDetailId { get; set; }
        public decimal? Point { get; set; }
        public DateTime? ExpireOn { get; set; }
        public Guid? PointTransactionId { get; set; }
        public string InternalRemark { get; set; }
        public string ExternalRemark { get; set; }
        public bool? IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? CreateDateTime { get; set; }

        public virtual PointTransaction PointTransaction { get; set; }
        public virtual AspNetUserDetail UserDetail { get; set; }
    }
}
