using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class Notarisation
    {
        public DateTime CreationDate { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime? FinishDate { get; set; }
        public int Id { get; set; }
        public string CandidateName { get; set; }
        public int ConsultantId { get; set; }
        public string ConsultantName { get; set; }
        public int ItemType { get; set; }
        public int Documents { get; set; }
        public int PrePayment { get; set; }
        public int ThirdPartyPaid { get; set; }
        public int DigitalCopyReceived { get; set; }
        public int HardCopyReceived { get; set; }
        public int FullPayment { get; set; }
        public double OwnCosts { get; set; }
        public double ThirdPartyCosts { get; set; }
        public double Fee { get; set; }
        public double GrossProfit { get; set; }
        public double ConsultantBonus { get; set; }
        public double NetProfit { get; set; }
        public string Citizenship { get; set; }
        public double? PrePayAmount { get; set; }
        public string AccountNo { get; set; }
        public string Password { get; set; }
        public DateTime? ConsultantFinishDate { get; set; }
        public DateTime? PrePaymentDate { get; set; }
    }
}
