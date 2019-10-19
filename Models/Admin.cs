using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? CanManageJobPosts { get; set; }
        public int? CanManageApplications { get; set; }
        public int? CanEditJobPosts { get; set; }
        public int? CanEditBlog { get; set; }
        public int? CanManageCandidates { get; set; }
        public int? CanManageEmployers { get; set; }
        public int? CanReadMessages { get; set; }
        public int? CanExportData { get; set; }
        public int? CanDeleteData { get; set; }
        public int? CanManageAdmin { get; set; }
        public int? Status { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastActiveDate { get; set; }
        public int? NeedToSetPassword { get; set; }
        public int? CanManageEventPosts { get; set; }
        public int? CanViewEventData { get; set; }
        public int? TrackKpi { get; set; }
        public int? ECcAdminCandViews { get; set; }
        public int? ViewsLastResetMonth { get; set; }
    }
}
