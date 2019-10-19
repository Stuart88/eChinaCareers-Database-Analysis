using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class ApplicationPipelineNote
    {
        public DateTime? CreationDate { get; set; }
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int ApplicationId { get; set; }
        public string Note { get; set; }
        public string AuthorName { get; set; }
    }
}
