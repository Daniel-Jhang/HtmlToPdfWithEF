using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataPopUp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
