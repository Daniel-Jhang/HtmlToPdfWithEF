using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ParkingDiscount
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public int? MemberSchemeId { get; set; }
        public int? DiscountHours { get; set; }
        public bool? IsCanceled { get; set; }
        public Guid ParkingId { get; set; }
        public bool? IsFinished { get; set; }
        public DateTime? FinishTime { get; set; }
        public DateTime? CreateTime { get; set; }

        public virtual MemberScheme MemberScheme { get; set; }
        public virtual Parking Parking { get; set; }
    }
}
