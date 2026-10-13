using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class IncomingWebhook
    {
        public long WebhookId { get; set; }
        public long? WorkspaceId { get; set; }
        public string Source { get; set; } = null!; // MetaWhatsApp, Shopify, Billing, etc.
        public string? EventType { get; set; }
        public string Payload { get; set; } = null!;
        public DateTime ReceivedAtUtc { get; set; }
        public DateTime? ProcessedAtUtc { get; set; }
        public string Status { get; set; } = null!; // Pending, Processed, Failed
        public string? ErrorMessage { get; set; }

        public Workspace? Workspace { get; set; }
    }
}
