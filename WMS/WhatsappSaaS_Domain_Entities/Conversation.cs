using System;
using System.Collections.Generic;

namespace WhatsappSaaS.Domain.Entities
{
    public class Conversation
    {
        public long ConversationId { get; set; }
        public long WorkspaceId { get; set; }
        public long ContactId { get; set; }
        public long ChannelConnectionId { get; set; }
        public byte ChannelType { get; set; } // 1 = WhatsApp, 2 = Instagram, 3 = Messenger
        public DateTime LastMessageAt { get; set; }
        public long? AssignedUserId { get; set; }
        public string? Status { get; set; } // Open, Pending, Closed
        public DateTime CreatedAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
        public Contact Contact { get; set; } = null!;
        public ChannelConnection ChannelConnection { get; set; } = null!;
        public User? AssignedUser { get; set; }

        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
