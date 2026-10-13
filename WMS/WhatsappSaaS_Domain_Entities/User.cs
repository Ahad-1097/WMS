using System;
using System.Collections.Generic;

namespace WhatsappSaaS.Domain.Entities
{
    public class User
    {
        public long UserId { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreatedAtUtc { get; set; }

        public ICollection<WorkspaceMember> WorkspaceMemberships { get; set; } = new List<WorkspaceMember>();
        public ICollection<Conversation> AssignedConversations { get; set; } = new List<Conversation>();
        public ICollection<Campaign> CreatedCampaigns { get; set; } = new List<Campaign>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
    }
}
