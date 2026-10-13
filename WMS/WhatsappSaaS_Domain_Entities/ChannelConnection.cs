using System;
using System.Collections.Generic;

namespace WhatsappSaaS.Domain.Entities
{
    public class ChannelConnection
    {
        public long ChannelConnectionId { get; set; }
        public long WorkspaceId { get; set; }
        public byte ChannelType { get; set; } // 1 = WhatsApp, 2 = Instagram, 3 = Messenger
        public string? ExternalBusinessId { get; set; }
        public string? ExternalPhoneNumberId { get; set; }
        public string? DisplayName { get; set; }
        public string? AccessTokenEncrypted { get; set; }
        public DateTime? TokenExpiresAt { get; set; }
        public string? Status { get; set; } // Connected, Error, Paused
        public string? QualityRating { get; set; } // WhatsApp only
        public int? DailyLimit { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime UpdatedAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
        public ICollection<Conversation> Conversations { get; set; } = new List<Conversation>();
    }
}
