using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class CarNumberAspnetUserDetail
    {
        public CarNumberAspnetUserDetail()
        {
            InversePrevCarNumberAspnetUserDetail = new HashSet<CarNumberAspnetUserDetail>();
        }

        public long Sqlid { get; set; }
        public Guid Id { get; set; }
        public Guid? AspnetUserDetailId { get; set; }
        public Guid? CarNumberId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsFromCrmCentral { get; set; }
        public Guid? PrevCarNumberAspnetUserDetailId { get; set; }

        public virtual AspNetUserDetail AspnetUserDetail { get; set; }
        public virtual CarNumber CarNumber { get; set; }
        public virtual CarNumberAspnetUserDetail PrevCarNumberAspnetUserDetail { get; set; }
        public virtual ICollection<CarNumberAspnetUserDetail> InversePrevCarNumberAspnetUserDetail { get; set; }
    }
}
