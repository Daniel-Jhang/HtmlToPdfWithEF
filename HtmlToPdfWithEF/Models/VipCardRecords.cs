using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class VipCardRecords
    {
        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyOn { get; set; }
        public int StatusCodeId { get; set; }
        public Guid ProgressId { get; set; }
        public string CardNo { get; set; }
        public string Location { get; set; }
        public string CardType { get; set; }
        public Guid? CardTypeId { get; set; }
        public string MemberName { get; set; }
        public string MemberId { get; set; }
        public string VipCardNo { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public bool HasProblem { get; set; }
        public decimal? Amount { get; set; }
        public string AdditionalMemberName { get; set; }
        public Guid? MemberLevelId { get; set; }
        public string ErrorMsg { get; set; }
        public Guid? CrmContactId { get; set; }
        public Guid? CrmMemberId { get; set; }
        public Guid? CrmCardDetailId { get; set; }
        public string FormalErrorMsg { get; set; }
        public string ApplyLocation { get; set; }
        public bool HasContact { get; set; }

        public virtual VipGeneratorProgress Progress { get; set; }
        public virtual VipCardStatusCode StatusCode { get; set; }
    }
}
