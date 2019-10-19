using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class EmailOptOut
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public int ReasonOption { get; set; }
        public string ReasonCustomText { get; set; }
    }
}
