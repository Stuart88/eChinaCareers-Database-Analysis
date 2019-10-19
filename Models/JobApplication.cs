using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class JobApplication
    {
        public int Id { get; set; }
        public int? JobId { get; set; }
        public string JobTitle { get; set; }
        public int? EmployerId { get; set; }
        public string EmployerName { get; set; }
        public int? ApplicantId { get; set; }
        public string ApplicantName { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public string ApplicantMessage { get; set; }
        public string ResponseMessage { get; set; }
        public int? Status { get; set; }
    }
}
