using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class AuditLog
    {
        public long AuditId { get; set; }
        public long WorkspaceId { get; set; }
        public long? UserId { get; set; }
        public string ActionType { get; set; } = null!; // Login, SendMessage, etc.
        public string? DetailsJson { get; set; }
        public DateTime CreatedAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
        public User? User { get; set; }
    }
}
