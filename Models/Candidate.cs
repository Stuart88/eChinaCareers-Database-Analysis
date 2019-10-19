using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class Candidate
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? Status { get; set; }
        public string DisplayName { get; set; }
        public string Phone { get; set; }
        public string JobTitle { get; set; }
        public string MinSalary { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string GooglePlus { get; set; }
        public string LinkedIn { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public int? BirthYear { get; set; }
        public string WorkExperience { get; set; }
        public string WorkExperienceUseThis { get; set; }
        public string EducationLevel { get; set; }
        public string MandarinLevel { get; set; }
        public string CurrentCountry { get; set; }
        public string CurrentCity { get; set; }
        public string Wechat { get; set; }
        public string Qq { get; set; }
        public string ProfileImage { get; set; }
        public string Cv { get; set; }
        public int? CvStatus { get; set; }
        public string Nickname2 { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Industry { get; set; }
        public string IndustryUseThis { get; set; }
        public string BillingEmail { get; set; }
        public string ExpectedSalary { get; set; }
        public int? ExpectedSalaryUseThis { get; set; }
        public string QualificationLevel { get; set; }
        public int? ChineseLevel { get; set; }
        public int? Credits { get; set; }
        public string ShortlistedJobsIds { get; set; }
        public string AppliedJobsIds { get; set; }
        public DateTime? LastActiveDate { get; set; }
        public int? FirstLogin { get; set; }
        public DateTime? LastApplicationSubmittedDate { get; set; }
        public int? ApplicationsMadeToday { get; set; }
        public int JobAlerts { get; set; }
        public string JobFunctionsCandidate { get; set; }
    }
}
