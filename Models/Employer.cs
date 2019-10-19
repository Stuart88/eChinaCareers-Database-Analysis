using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class Employer
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? Status { get; set; }
        public string DisplayNameEn { get; set; }
        public string Phone { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string GooglePlus { get; set; }
        public string LinkedIn { get; set; }
        public string Wechat { get; set; }
        public string ProfileImage { get; set; }
        public string Nickname2 { get; set; }
        public string Description { get; set; }
        public string IndustryIgnore { get; set; }
        public string BillingEmail { get; set; }
        public int? JobPostCredits { get; set; }
        public int? CvdownloadCredits { get; set; }
        public string Qq { get; set; }
        public string Industry { get; set; }
        public int? Views { get; set; }
        public int? Verified { get; set; }
        public string DisplayNameZh { get; set; }
        public string Address { get; set; }
        public string CompanySizeNoOfEmployees { get; set; }
        public string ViewableCandidatesIds { get; set; }
        public string ShortlistedCandidatesIds { get; set; }
        public DateTime? LastActiveDate { get; set; }
        public int? FirstLogin { get; set; }
        public string ContactPerson { get; set; }
        public int? HomepageFeatured { get; set; }
        public int? OldId { get; set; }
        public int? MembershipType { get; set; }
        public DateTime? MembershipExpires { get; set; }
        public int? CandidateContactCredits { get; set; }
        public int? EmployerType { get; set; }
    }
}
