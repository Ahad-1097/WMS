using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class WordPressSite
    {
        public long WordPressSiteId { get; set; }
        public long WorkspaceId { get; set; }
        public string SiteUrl { get; set; } = null!;
        public string? ApiKeyEncrypted { get; set; }
        public bool IsActive { get; set; }
        public DateTime ConnectedAtUtc { get; set; }
        public DateTime? DisconnectedAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
    }
}
