using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class ApplicationPipeline
    {
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public int JobId { get; set; }
        public int CompanyId { get; set; }
        public string CandidateName { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public int? Recommended { get; set; }
        public int? Interview { get; set; }
        public int? OfferGiven { get; set; }
        public int? OfferRejected { get; set; }
        public int? OfferAccepted { get; set; }
        public DateTime? WorkStartDate { get; set; }
        public int? PassedProbation { get; set; }
        public int RecruiterId { get; set; }
        public string RecruiterName { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string PipelineTerminatedReason { get; set; }
        public int? PipelineTerminated { get; set; }
        public string Note { get; set; }
        public DateTime? OfferGivenDate { get; set; }
        public DateTime? OfferAcceptedDate { get; set; }
        public DateTime? OfferRejectedDate { get; set; }
        public DateTime? PobationPassedDate { get; set; }
        public int? NotFirstInterview { get; set; }
    }
}
