using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class RecruitingJobPost
    {
        public DateTime CreationDate { get; set; }
        public DateTime LastModified { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
        public int NumberOfHires { get; set; }
        public int Priority { get; set; }
        public string Functions { get; set; }
        public string Locations { get; set; }
        public DateTime JobStartDate { get; set; }
        public int? SalaryMin { get; set; }
        public int? SalaryMax { get; set; }
        public string JobDescription { get; set; }
        public string Notes { get; set; }
        public int? ProbationTime { get; set; }
        public int? Fee { get; set; }
        public string CompanyType { get; set; }
        public int? OldId { get; set; }
        public int? FeeMax { get; set; }
        public double? FeePercent { get; set; }
    }
}
