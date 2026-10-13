using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class WorkspaceMember
    {
        public long Id { get; set; }
        public long WorkspaceId { get; set; }
        public long UserId { get; set; }
        public string Role { get; set; } = null!; // Owner, Admin, Agent
        public DateTime JoinedAt { get; set; }

        public Workspace Workspace { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
