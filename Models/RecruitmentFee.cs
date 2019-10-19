using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class RecruitmentFee
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModified { get; set; }
        public string CandidateName { get; set; }
        public int ConsultantId { get; set; }
        public string ConsultantName { get; set; }
        public string JobTitle { get; set; }
        public int JobId { get; set; }
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
