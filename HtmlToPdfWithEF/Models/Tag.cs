using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Tag
    {
        public Tag()
        {
            AspnetUserDetailIdTag = new HashSet<AspnetUserDetailIdTag>();
            InversePrevTag = new HashSet<Tag>();
            MarketingCostTag = new HashSet<MarketingCostTag>();
        }

        public Guid Id { get; set; }
        public int SqlId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? StartTime { get; set; }
        public int? EndTime { get; set; }
        public Guid? ActivityId { get; set; }
        public int? BenefitId { get; set; }
        public int? OperatorAmountId { get; set; }
        public decimal? TransactionAmount { get; set; }
        public int? OperatorPointId { get; set; }
        public decimal? TransactionPoint { get; set; }
        public int? AccumulationId { get; set; }
        public int? OperatorFrequencyId { get; set; }
        public int? Frequency { get; set; }
        public int? MemberSchemeTypeId { get; set; }
        public int? MemberSchemeId { get; set; }
        public int? MonthOrWeekId { get; set; }
        public int? SpecialDay { get; set; }
        public int? MatchCount { get; set; }
        public int? SpecialStartHour { get; set; }
        public int? SpecialStartMinute { get; set; }
        public int? SpecialEndHour { get; set; }
        public int? SpecialEndMinute { get; set; }
        public string Fixedday { get; set; }
        public int? MarketingCostTypeId { get; set; }
        public int? ShopId { get; set; }
        public Guid? FloorId { get; set; }
        public int? ShopCategoryId { get; set; }
        public Guid? PrevTagId { get; set; }
        public Guid? TagGroupId { get; set; }
        public int? TagGroupPriority { get; set; }
        public Guid? CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public int? TagCustCategoryId { get; set; }
        public int? MatchCondition { get; set; }
        public int? OperatorParkingHoursId { get; set; }
        public int? ParkingHours { get; set; }

        public virtual Accumulation Accumulation { get; set; }
        public virtual TagCategory Category { get; set; }
        public virtual Floor Floor { get; set; }
        public virtual MarketingCostType MarketingCostType { get; set; }
        public virtual TagMonthOrWeek MonthOrWeek { get; set; }
        public virtual TagOperator OperatorAmount { get; set; }
        public virtual TagOperator OperatorFrequency { get; set; }
        public virtual TagOperator OperatorParkingHours { get; set; }
        public virtual TagOperator OperatorPoint { get; set; }
        public virtual Tag PrevTag { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual ShopCategory ShopCategory { get; set; }
        public virtual TagCustCategory TagCustCategory { get; set; }
        public virtual TagGroup TagGroup { get; set; }
        public virtual ICollection<AspnetUserDetailIdTag> AspnetUserDetailIdTag { get; set; }
        public virtual ICollection<Tag> InversePrevTag { get; set; }
        public virtual ICollection<MarketingCostTag> MarketingCostTag { get; set; }
    }
}
