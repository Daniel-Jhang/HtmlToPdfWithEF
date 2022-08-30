using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ModifyPoint
    {
        public ModifyPoint()
        {
            ModifyPointRecord = new HashSet<ModifyPointRecord>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }

        public virtual ICollection<ModifyPointRecord> ModifyPointRecord { get; set; }
    }
}
