using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public int? EmployerId { get; set; }
        public int? CandidateId { get; set; }
        public int? AdminId { get; set; }
        public int? PasswordReset { get; set; }
        public string TemporaryTrackingCookie { get; set; }
        public int? Status { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
    }
}
