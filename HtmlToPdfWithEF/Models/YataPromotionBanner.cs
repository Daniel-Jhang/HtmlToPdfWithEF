using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class YataPromotionBanner
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public int? PinToTopId { get; set; }
        public int? PopUpId { get; set; }
        public string Name { get; set; }
        public string PromotionBannerNo { get; set; }
        public string BannerTitleC { get; set; }
        public string BannerTitleE { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? PostingFromDate { get; set; }
        public DateTime? PostingToDate { get; set; }
        public DateTime? PopUpPostingFromDate { get; set; }
        public DateTime? PopUpPostingToDate { get; set; }
        public bool? IsDeleted { get; set; }
        public string CrmId { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public Guid? InterestId { get; set; }
        public Guid? CategoryId { get; set; }
        public string RemarkTextC { get; set; }
        public string RemarkTextE { get; set; }
        public string MainTextC { get; set; }
        public string MainTextE { get; set; }
        public string TcC { get; set; }
        public string TcE { get; set; }
        public string HomeBannerDetailPathC { get; set; }
        public string HomeBannerDetailPathE { get; set; }
        public string SmallBannerImageC { get; set; }
        public string SmallBannerImageE { get; set; }
        public string BigBannerImage1C { get; set; }
        public string BigBannerImage1E { get; set; }
        public string BigBannerImage2C { get; set; }
        public string BigBannerImage2E { get; set; }
        public string BigBannerImage3C { get; set; }
        public string BigBannerImage3E { get; set; }
        public string BigBannerImage4C { get; set; }
        public string BigBannerImage4E { get; set; }
        public string BigBannerImage5C { get; set; }
        public string BigBannerImage5E { get; set; }
        public string BigBannerImage6C { get; set; }
        public string BigBannerImage6E { get; set; }
        public string BigBannerImage7C { get; set; }
        public string BigBannerImage7E { get; set; }
        public string BigBannerImage8C { get; set; }
        public string BigBannerImage8E { get; set; }
        public string BigBannerImage9C { get; set; }
        public string BigBannerImage9E { get; set; }
        public string BigBannerImage10C { get; set; }
        public string BigBannerImage10E { get; set; }
        public string PopUpImageC { get; set; }
        public string PopUpImageE { get; set; }
        public string VideoThumbnailImageC { get; set; }
        public string VideoThumbnailImageE { get; set; }
        public string VideoPathC { get; set; }
        public string VideoPathE { get; set; }

        public virtual YataPromotionBannerCategory Category { get; set; }
        public virtual YataPinToTop PinToTop { get; set; }
    }
}
