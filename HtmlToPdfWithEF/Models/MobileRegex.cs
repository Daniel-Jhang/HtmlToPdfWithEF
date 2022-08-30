using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MobileRegex
    {
        public MobileRegex()
        {
            MobileVerification = new HashSet<MobileVerification>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ValidateRegex { get; set; }
        public int MaxNumbers { get; set; }
        public string ExcludeVerifyRegex { get; set; }
        public string Description { get; set; }
        public int? PrefixOptionSet { get; set; }

        public virtual ICollection<MobileVerification> MobileVerification { get; set; }
    }
}
