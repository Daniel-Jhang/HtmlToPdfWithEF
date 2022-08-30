using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Parking
    {
        public Parking()
        {
            ParkingDiscount = new HashSet<ParkingDiscount>();
            ParkingPayment = new HashSet<ParkingPayment>();
        }

        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string CarNumber { get; set; }
        public DateTime? EntryDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string MarketCode { get; set; }
        public DateTime? ExitTime { get; set; }
        public bool? IsCanceled { get; set; }
        public string IntoParkingId { get; set; }
        public string CardNumber { get; set; }
        public Guid? CarNumberId { get; set; }

        public virtual CarNumber CarNumberNavigation { get; set; }
        public virtual AspNetUserDetail User { get; set; }
        public virtual ICollection<ParkingDiscount> ParkingDiscount { get; set; }
        public virtual ICollection<ParkingPayment> ParkingPayment { get; set; }
    }
}
