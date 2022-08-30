using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Currency
    {
        public Currency()
        {
            EcouponRecord = new HashSet<EcouponRecord>();
            MemberScheme = new HashSet<MemberScheme>();
            PriceList = new HashSet<PriceList>();
            RedeemTransaction = new HashSet<RedeemTransaction>();
            RedeemTransactionDetail = new HashSet<RedeemTransactionDetail>();
            SalesPaymentDetail = new HashSet<SalesPaymentDetail>();
            SalesTransaction = new HashSet<SalesTransaction>();
            SalesTransactionDetail = new HashSet<SalesTransactionDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CrmId { get; set; }
        public decimal? ExChangeRate { get; set; }

        public virtual ICollection<EcouponRecord> EcouponRecord { get; set; }
        public virtual ICollection<MemberScheme> MemberScheme { get; set; }
        public virtual ICollection<PriceList> PriceList { get; set; }
        public virtual ICollection<RedeemTransaction> RedeemTransaction { get; set; }
        public virtual ICollection<RedeemTransactionDetail> RedeemTransactionDetail { get; set; }
        public virtual ICollection<SalesPaymentDetail> SalesPaymentDetail { get; set; }
        public virtual ICollection<SalesTransaction> SalesTransaction { get; set; }
        public virtual ICollection<SalesTransactionDetail> SalesTransactionDetail { get; set; }
    }
}
