using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class CandidatePictureNew
    {
        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public string WebPath { get; set; }
        public string LocalPath { get; set; }
        public int? Status { get; set; }
    }
}
