using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ReportExpirePointToRevenue
    {
        public int Id { get; set; }
        public int MainMemberSchemeType { get; set; }
        public int SecondMemberSchemeType { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal MainPoint { get; set; }
        public decimal SecondPoint { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
