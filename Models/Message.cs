using System;
using System.Collections.Generic;

namespace DatabaseAnalysis.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string MessageSubject { get; set; }
        public string MessageText { get; set; }
        public int? Status { get; set; }
        public int? MessageType { get; set; }
        public int? MessageCategory { get; set; }
        public int? SenderId { get; set; }
        public string SenderName { get; set; }
        public int? RecipientId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? MessageSeen { get; set; }
        public DateTime? MessageSeenDate { get; set; }
    }
}
