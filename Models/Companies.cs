using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class Companies
    {
        public string CompanyName { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
        public string StartDate { get; set; }
        public string Level { get; set; }
        public string SchoolLisence { get; set; }
        public string Native { get; set; }
        public string NonNative { get; set; }
        public string Ds { get; set; }
        public int Id { get; set; }
        public int? SalaryMin { get; set; }
        public int? SalaryMax { get; set; }
        public int? Asap { get; set; }
        public int? Fee { get; set; }
        public string Note { get; set; }
        public int? ProbationPerdiod { get; set; }
        public int? ContractStatus { get; set; }
        public string Industry { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? UploadedById { get; set; }
        public string UploadedByName { get; set; }
        public DateTime? ContractStart { get; set; }
        public DateTime? ContractEnd { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Wechat { get; set; }
        public string ContactPerson { get; set; }
        public string Qq { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyNameZh { get; set; }
        public int? OldId { get; set; }
        public string Website { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? ThirdParty { get; set; }
        public int? FeeMax { get; set; }
        public double? FeePercent { get; set; }
    }
}
