using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class PhysicalCardDetailCrm
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string CrmId { get; set; }
    }
}
