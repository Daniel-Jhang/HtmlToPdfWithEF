using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class DailyReport
    {
        public int Id { get; set; }
        public string TransactionDetail { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? MarketId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? CreateDateTime { get; set; }
    }
}
