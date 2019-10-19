using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class NotarisationAttachment
    {
        public DateTime? CreationDate { get; set; }
        public int Id { get; set; }
        public int NotarisationId { get; set; }
        public string DiskLocation { get; set; }
        public string WebLocation { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
    }
}
