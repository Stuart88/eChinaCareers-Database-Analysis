using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class Event
    {
        public Event()
        {
            EventVisitor = new HashSet<EventVisitor>();
        }

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public string Content { get; set; }
        public int? IncludeFirstName { get; set; }
        public int? IncludeLastName { get; set; }
        public int? IncludeGender { get; set; }
        public int? IncludeNationality { get; set; }
        public int? IncludeBirthdate { get; set; }
        public int? IncludeEmail { get; set; }
        public int? IncludePhone { get; set; }
        public int? IncludeCurrentLocation { get; set; }
        public int? IncludeCurrentJobTitle { get; set; }
        public int? IncludeCurrentSalary { get; set; }
        public int? IncludeDesiredSalary { get; set; }
        public int? IncludeMajor { get; set; }
        public int? IncludeHighestQualification { get; set; }
        public int? IncludeIndustry { get; set; }
        public int? IncludeLinkedIn { get; set; }
        public int? IncludeWorkExperience { get; set; }
        public int? IncludeChineseLevel { get; set; }
        public int? IncludeWechat { get; set; }
        public int? IncludeFileUpload { get; set; }
        public int? IncludeUniversityName { get; set; }
        public int? IncludeCompanyName { get; set; }
        public int? EventViews { get; set; }
        public string Locations { get; set; }

        public virtual ICollection<EventVisitor> EventVisitor { get; set; }
    }
}
