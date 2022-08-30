using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ActivityPointExpireTime
    {
        public ActivityPointExpireTime()
        {
            UserPoint = new HashSet<UserPoint>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int? ExpireDays { get; set; }
        public Guid? ActivityId { get; set; }
        public Guid? PointTypeId { get; set; }
        public Guid? RslId { get; set; }
        public DateTime? RslModifiedTime { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string Name { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual PointType PointType { get; set; }
        public virtual ICollection<UserPoint> UserPoint { get; set; }
    }
}
