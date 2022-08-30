using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class CarNumber
    {
        public CarNumber()
        {
            CarNumberAspnetUserDetail = new HashSet<CarNumberAspnetUserDetail>();
            Parking = new HashSet<Parking>();
        }

        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CarLicenseNumber { get; set; }
        public Guid? CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsInventorySync { get; set; }

        public virtual ICollection<CarNumberAspnetUserDetail> CarNumberAspnetUserDetail { get; set; }
        public virtual ICollection<Parking> Parking { get; set; }
    }
}
