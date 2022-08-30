using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class VipGeneratorProgress
    {
        public VipGeneratorProgress()
        {
            VipCardRecords = new HashSet<VipCardRecords>();
        }

        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyOn { get; set; }
        public int StatusCodeId { get; set; }
        public Guid CrmId { get; set; }
        public bool IsDisable { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMsg { get; set; }
        public string ErrorInfo { get; set; }
        public string Args { get; set; }

        public virtual VipCardStatusCode StatusCode { get; set; }
        public virtual ICollection<VipCardRecords> VipCardRecords { get; set; }
    }
}
