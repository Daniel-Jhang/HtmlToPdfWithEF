using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class TagOperator
    {
        public TagOperator()
        {
            TagOperatorAmount = new HashSet<Tag>();
            TagOperatorFrequency = new HashSet<Tag>();
            TagOperatorParkingHours = new HashSet<Tag>();
            TagOperatorPoint = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EnName { get; set; }
        public int? OptionSetValue { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Tag> TagOperatorAmount { get; set; }
        public virtual ICollection<Tag> TagOperatorFrequency { get; set; }
        public virtual ICollection<Tag> TagOperatorParkingHours { get; set; }
        public virtual ICollection<Tag> TagOperatorPoint { get; set; }
    }
}
