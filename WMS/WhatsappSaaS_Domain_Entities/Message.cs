using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class Message
    {
        public long MessageId { get; set; }
        public long ConversationId { get; set; }
        public long WorkspaceId { get; set; }
        public byte ChannelType { get; set; } // 1 = WhatsApp
        public byte Direction { get; set; } // 1 = Incoming, 2 = Outgoing, 3 = Automation, 4 = System

        public string? Content { get; set; }
        public string? TemplateName { get; set; }
        public bool IsTemplate { get; set; }
        public string? WhatsAppCategory { get; set; } // marketing, utility, service, auth
        public string? PlatformMessageId { get; set; } // Meta message ID

        public string Status { get; set; } = null!; // Queued, Sending, Sent, Delivered, Read, Failed
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? SentAtUtc { get; set; }
        public DateTime? DeliveredAtUtc { get; set; }
        public DateTime? ReadAtUtc { get; set; }

        public bool IsBillable { get; set; }
        public bool CountedInUsage { get; set; }
        public DateTime? BilledAtUtc { get; set; }

        public string? ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }

        public Workspace Workspace { get; set; } = null!;
        public Conversation Conversation { get; set; } = null!;
        public CampaignMessage? CampaignMessage { get; set; }
    }
}
