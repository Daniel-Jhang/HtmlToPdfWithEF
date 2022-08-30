using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataSalutation
    {
        public int Id { get; set; }
        public bool? IsDeleted { get; set; }
        public string Name { get; set; }
        public string Namec { get; set; }
        public int? OptionSetValue { get; set; }
    }
}
