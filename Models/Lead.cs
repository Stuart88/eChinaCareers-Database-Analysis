using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class Lead
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModified { get; set; }
        public string CandidateName { get; set; }
        public string ConsultantName { get; set; }
        public string JobTitle { get; set; }
        public int FirstAttempt { get; set; }
        public DateTime? FirstAttemptDate { get; set; }
        public int SecondAttempt { get; set; }
        public DateTime? SecondAttemptDate { get; set; }
        public int? Status { get; set; }
        public string Link { get; set; }
        public int ConsultantId { get; set; }
    }
}
