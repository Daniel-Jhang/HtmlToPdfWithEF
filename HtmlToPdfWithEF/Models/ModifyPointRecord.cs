using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class ModifyPointRecord
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string TableName { get; set; }
        public Guid? SourceId { get; set; }
        public Guid? UserDetailId { get; set; }
        public Guid? ModifyPointId { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? SourceExpireDateTime { get; set; }
        public DateTime? NewExpireDateTime { get; set; }

        public virtual ModifyPoint ModifyPoint { get; set; }
    }
}
