using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MobileVerification
    {
        public int Id { get; set; }
        public Guid VerifiedSqlId { get; set; }
        public string PhoneNumber { get; set; }
        public string Code { get; set; }
        public DateTime VerifiedTime { get; set; }
        public int CountryCode { get; set; }

        public virtual MobileRegex CountryCodeNavigation { get; set; }
    }
}
