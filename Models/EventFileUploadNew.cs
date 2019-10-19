using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class EventFileUploadNew
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int VisitorId { get; set; }
        public string WebPath { get; set; }
        public string LocalPath { get; set; }
    }
}
