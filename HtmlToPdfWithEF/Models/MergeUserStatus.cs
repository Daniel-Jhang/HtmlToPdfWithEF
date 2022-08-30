using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MergeUserStatus
    {
        public MergeUserStatus()
        {
            MergeUserRecord = new HashSet<MergeUserRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MergeUserRecord> MergeUserRecord { get; set; }
    }
}
