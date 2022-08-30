using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ServiceStatus
    {
        public ServiceStatus()
        {
            ServiceLock = new HashSet<ServiceLock>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ServiceLock> ServiceLock { get; set; }
    }
}
