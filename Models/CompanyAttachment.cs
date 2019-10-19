using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class CompanyAttachment
    {
        public DateTime? CreationDate { get; set; }
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string DiskLocation { get; set; }
        public string WebLocation { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
    }
}
