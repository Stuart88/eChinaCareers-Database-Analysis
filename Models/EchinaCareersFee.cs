using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class EchinaCareersFee
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModified { get; set; }
        public string CustomerName { get; set; }
        public string Package { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int EmployerId { get; set; }
    }
}
