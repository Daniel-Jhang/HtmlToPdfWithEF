using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class OctopusType
    {
        public OctopusType()
        {
            Market = new HashSet<Market>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? OptionSetValue { get; set; }

        public virtual ICollection<Market> Market { get; set; }
    }
}
