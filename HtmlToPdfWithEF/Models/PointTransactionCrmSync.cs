using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PointTransactionCrmSync
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid PointTransactionId { get; set; }
        public DateTime? CrmUpdateTime { get; set; }
        public Guid? CrmId { get; set; }

        public virtual PointTransaction PointTransaction { get; set; }
    }
}
