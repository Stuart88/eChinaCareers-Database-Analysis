using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class BonusPercentage
    {
        public int Id { get; set; }
        public double Notarisation { get; set; }
        public double Visa { get; set; }
        public double Degree { get; set; }
    }
}
