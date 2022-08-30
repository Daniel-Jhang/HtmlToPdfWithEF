using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class VContact
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string ChineseName { get; set; }
        public string ChineseLastName { get; set; }
        public string MemberNo { get; set; }
        public int? Gender { get; set; }
        public int? BirthYear { get; set; }
        public int? BirthMonth { get; set; }
        public int? CountryCodeId { get; set; }
        public Guid? CrmId { get; set; }
        public string BuildingName { get; set; }
        public string Floor { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? RegionId { get; set; }
        public int? DistrictId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool? EmailOptOut { get; set; }
        public string Address { get; set; }
        public DateTime? MigrationTime { get; set; }
        public string AppAddressLine1 { get; set; }
        public string AppAddressLine2 { get; set; }
        public bool? CancelMembership { get; set; }
        public bool? MobilOptOut { get; set; }
        public bool? PostOptOut { get; set; }
        public bool? SmsoptOut { get; set; }
        public bool? PushOptOut { get; set; }
        public int? PreferredLanguageId { get; set; }
        public Guid? ReferredBy { get; set; }
        public string Sfid { get; set; }
        public int? SalutationId { get; set; }
        public DateTime? FirstLoginTime { get; set; }
        public int? RegisterFromId { get; set; }
        public int? StateCodesId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string UpdateStamp { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
