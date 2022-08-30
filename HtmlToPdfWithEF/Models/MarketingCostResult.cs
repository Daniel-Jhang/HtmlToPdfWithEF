using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class MarketingCostResult
    {
        public MarketingCostResult()
        {
            Edmclick = new HashSet<Edmclick>();
            PushClick = new HashSet<PushClick>();
        }

        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? UserDetailId { get; set; }
        public string UserDetailCode { get; set; }
        public bool TestSender { get; set; }
        public string KeyValue { get; set; }
        public int SendResultId { get; set; }
        public int? ReseponseResultId { get; set; }
        public int? SmsstatusCodeId { get; set; }
        public int? SmsfinalStatusCodeId { get; set; }
        public int? SmsstatusFlagStatusCodeId { get; set; }
        public string MsgId { get; set; }
        public string EdmpostId { get; set; }
        public string EdmsuccessId { get; set; }
        public Guid? PushRequestId { get; set; }
        public int? PushEven { get; set; }
        public Guid? MarketingCostRecordId { get; set; }
        public Guid MarketingCostCrmId { get; set; }
        public int? SendCount { get; set; }
        public bool IsOpened { get; set; }
        public bool IsClicked { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? ClickTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual MarketingCostRecord MarketingCostRecord { get; set; }
        public virtual MarketingCostReseponseResult ReseponseResult { get; set; }
        public virtual SendResult SendResult { get; set; }
        public virtual SmsstatusCode SmsstatusCode { get; set; }
        public virtual SmsstatusCode SmsstatusFlagStatusCode { get; set; }
        public virtual AspNetUserDetail UserDetail { get; set; }
        public virtual ICollection<Edmclick> Edmclick { get; set; }
        public virtual ICollection<PushClick> PushClick { get; set; }
    }
}
