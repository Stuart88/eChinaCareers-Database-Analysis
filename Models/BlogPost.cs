using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class BlogPost
    {
        public int Id { get; set; }
        public string PostTitle { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? PostDate { get; set; }
        public string PostText { get; set; }
        public string MainImageUrl { get; set; }
        public int? PosterId { get; set; }
        public string PosterName { get; set; }
        public int? Views { get; set; }
        public int? Status { get; set; }
        public string Lang { get; set; }
        public string Option { get; set; }
        public string Meta { get; set; }
    }
}
