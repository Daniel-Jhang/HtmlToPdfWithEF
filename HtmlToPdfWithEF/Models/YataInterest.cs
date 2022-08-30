using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataInterest
    {
        public YataInterest()
        {
            YataUserDetailInterest = new HashSet<YataUserDetailInterest>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public bool? IsDeleted { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public Guid? Ownerid { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmCreateOnTime { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string Type { get; set; }

        public virtual ICollection<YataUserDetailInterest> YataUserDetailInterest { get; set; }
    }
}
