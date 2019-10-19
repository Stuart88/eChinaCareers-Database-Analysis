using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class Membership
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }
        public int? LengthDays { get; set; }
        public int Credits { get; set; }
        public int? CostYuan { get; set; }
        public int? CvCredits { get; set; }
        public int? CandidateContactCredits { get; set; }
    }
}
