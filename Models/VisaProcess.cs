using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class VisaProcess
    {
        public DateTime CreationDate { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime? FinishDate { get; set; }
        public int Id { get; set; }
        public string CandidateName { get; set; }
        public string CompanyName { get; set; }
        public int ConsultantId { get; set; }
        public string ConsultantName { get; set; }
        public int VisaType { get; set; }
        public int Payment { get; set; }
        public int Prepaid { get; set; }
        public int NonCriminal { get; set; }
        public int Degree { get; set; }
        public int ContactCard { get; set; }
        public int OnlineResult { get; set; }
        public int Notification { get; set; }
        public int WorkVisa { get; set; }
        public int HealthCheck { get; set; }
        public int RegisterForm { get; set; }
        public int WorkPermitCard { get; set; }
        public int ResidencePermit { get; set; }
        public double Fee { get; set; }
        public double? ConsultantBonus { get; set; }
        public double? OwnCosts { get; set; }
        public double? NetProfit { get; set; }
        public double? GrossProfit { get; set; }
        public DateTime? ConsultantFinishedDate { get; set; }
        public int? ConsultantFinished { get; set; }
        public double? PrePayAmount { get; set; }
        public int? OnlineAccount { get; set; }
        public int? Terminated { get; set; }
        public string AccountNo { get; set; }
        public string Password { get; set; }
        public DateTime? PrePaymentDate { get; set; }
    }
}
