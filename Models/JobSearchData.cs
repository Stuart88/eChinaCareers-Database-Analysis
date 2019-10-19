using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class JobSearchData
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Keywords { get; set; }
        public string Locations { get; set; }
        public string Industries { get; set; }
        public string JobType { get; set; }
        public int? MinSalary { get; set; }
        public int? MaxSalary { get; set; }
        public string JobFunctions { get; set; }
        public int IsCandidate { get; set; }
        public int IsEmployer { get; set; }
    }
}
