using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class RecruiterCandidate
    {
        public int Id { get; set; }
        public int? CandidateIdWebsite { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? Gender { get; set; }
        public int? Status { get; set; }
        public string Phone { get; set; }
        public string JobTitle { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string GooglePlus { get; set; }
        public string LinkedIn { get; set; }
        public string Nationality { get; set; }
        public string WorkExperience { get; set; }
        public string CurrentLocation { get; set; }
        public string Wechat { get; set; }
        public string Qq { get; set; }
        public int? CvStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Industry { get; set; }
        public string QualificationLevel { get; set; }
        public int? ChineseLevel { get; set; }
        public int? Credits { get; set; }
        public string JobFunctionsCandidate { get; set; }
        public int? CurrentVisa { get; set; }
        public DateTime? VisaExpiryDate { get; set; }
        public int? CriminalRercord { get; set; }
        public int? AcademicRecord { get; set; }
        public string ExpectedCities { get; set; }
        public int? ExpectedSalary { get; set; }
        public string Note { get; set; }
        public string Cvlocation { get; set; }
        public string ImageLocation { get; set; }
        public string VideoLocation { get; set; }
        public string WorkStartDate { get; set; }
        public string UrlId { get; set; }
        public int? Age { get; set; }
        public DateTime? LastModified { get; set; }
        public int? Potential { get; set; }
        public string Source { get; set; }
        public DateTime? LastContactDate { get; set; }
        public int? PhoneContactAttempts { get; set; }
        public int? EmailContactAttempts { get; set; }
        public string ContactMethod { get; set; }
        public string CurrentCompany { get; set; }
        public int? UploadedById { get; set; }
        public string UploadedByName { get; set; }
        public string UniversityName { get; set; }
        public int? OldId { get; set; }
        public string OriginalCvLocation { get; set; }
        public int? Tefl { get; set; }
        public int? ThirdPartyId { get; set; }
        public string ThirdPartyName { get; set; }
        public string ThirdPartyNote { get; set; }
    }
}
