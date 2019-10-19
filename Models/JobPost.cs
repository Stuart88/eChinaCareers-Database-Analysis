using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class JobPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreationDateIgnore { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Specialisms { get; set; }
        public string JobType { get; set; }
        public string Locations { get; set; }
        public string CsUser { get; set; }
        public string SalaryPackage { get; set; }
        public string CareerLevel { get; set; }
        public string ClosingDateIgnore { get; set; }
        public DateTime? ClosingDate { get; set; }
        public string AuthorCountry { get; set; }
        public string AuthorCity { get; set; }
        public string JobFeatured { get; set; }
        public string JobId { get; set; }
        public int? JobUsername { get; set; }
        public string ExpiryDateIgnore { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string StatusIgnore { get; set; }
        public int? Status { get; set; }
        public string CompanyName { get; set; }
        public string WorkLocation { get; set; }
        public string ChineseRequired { get; set; }
        public string Salary { get; set; }
        public string AvailableToIgnore { get; set; }
        public string AvailableTo { get; set; }
        public string JobReferral { get; set; }
        public string QualificationIgnore { get; set; }
        public string Qualification { get; set; }
        public int? Views { get; set; }
        public int? Applications { get; set; }
        public DateTime? LastViewDate { get; set; }
        public string JobFeaturedHomePage { get; set; }
        public DateTime? JobFeaturedHomePageEndDate { get; set; }
        public DateTime? JobFeatredEndDate { get; set; }
        public int? SalaryMax { get; set; }
        public int? SalaryMin { get; set; }
        public string JobFunctions { get; set; }
        public string ApplicantIdsList { get; set; }
        public int? SentReminderEmail { get; set; }
        public int Online { get; set; }
        public int? SchoolId { get; set; }
    }
}
