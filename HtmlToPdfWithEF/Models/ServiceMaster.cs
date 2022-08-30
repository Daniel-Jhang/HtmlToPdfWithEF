using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ServiceMaster
    {
        public ServiceMaster()
        {
            ServiceLock = new HashSet<ServiceLock>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ServiceLock> ServiceLock { get; set; }
    }
}
