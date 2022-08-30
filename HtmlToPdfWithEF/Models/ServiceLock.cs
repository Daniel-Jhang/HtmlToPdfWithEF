using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ServiceLock
    {
        public int SqlId { get; set; }
        public Guid ServiceMasterId { get; set; }
        public bool? IsLock { get; set; }
        public DateTime? LockTime { get; set; }
        public byte[] Rowversion { get; set; }
        public Guid CrmId { get; set; }
        public int Status { get; set; }
        public string ErrorMessage { get; set; }

        public virtual ServiceMaster ServiceMaster { get; set; }
        public virtual ServiceStatus StatusNavigation { get; set; }
    }
}
