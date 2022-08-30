using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ParkingPayment
    {
        public long SqlId { get; set; }
        public Guid Id { get; set; }
        public DateTime? PaymentDateTime { get; set; }
        public string InvoiceNumber { get; set; }
        public string ReciptNumber { get; set; }
        public int? PaymentTypeId { get; set; }
        public Guid? PurchaseTransactionId { get; set; }
        public int? PaymentLocationId { get; set; }
        public Guid? ParkingId { get; set; }
        public bool? IsCanceled { get; set; }
        public Guid? PointTransactionId { get; set; }

        public virtual Parking Parking { get; set; }
        public virtual PointTransaction PointTransaction { get; set; }
        public virtual PurchaseTransaction PurchaseTransaction { get; set; }
    }
}
