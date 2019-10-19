using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class EventVisitor
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public int? Birthdate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CurrentLocation { get; set; }
        public string CurrentJobTitle { get; set; }
        public int? CurrentSalary { get; set; }
        public int? DesiredSalary { get; set; }
        public string Major { get; set; }
        public string HighestQualification { get; set; }
        public string Industry { get; set; }
        public string LinkedIn { get; set; }
        public int? ChineseLevel { get; set; }
        public string Wechat { get; set; }
        public string CompanyName { get; set; }
        public string UniversityName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int? RegisteredToEcc { get; set; }
        public string WorkExperience { get; set; }
        public string EventLocation { get; set; }
        public DateTime? QrcodeScanDate { get; set; }
        public int? AttendedEvent { get; set; }

        public virtual Event Event { get; set; }
    }
}
