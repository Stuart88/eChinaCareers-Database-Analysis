using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class Statistics
    {
        public int Id { get; set; }
        public int? Applications { get; set; }
        public int? Views { get; set; }
    }
}
