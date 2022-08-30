using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class VipCardStatusCode
    {
        public VipCardStatusCode()
        {
            VipCardRecords = new HashSet<VipCardRecords>();
            VipGeneratorProgress = new HashSet<VipGeneratorProgress>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<VipCardRecords> VipCardRecords { get; set; }
        public virtual ICollection<VipGeneratorProgress> VipGeneratorProgress { get; set; }
    }
}
