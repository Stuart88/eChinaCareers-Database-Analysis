using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class CandidateFinancialTransaction
    {
        public int Id { get; set; }
        public int? TransactionType { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public int? CandidateId { get; set; }
        public double? AmountPaid { get; set; }
        public double? TaxRate { get; set; }
        public double? Net { get; set; }
        public double? Gross { get; set; }
        public int? AdminTellerId { get; set; }
        public int? CreditsExchanged { get; set; }
    }
}
