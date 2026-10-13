using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class BillingWebhookEvent
    {
        public long BillingWebhookEventId { get; set; }
        public long? WorkspaceId { get; set; }
        public string Provider { get; set; } = null!; // Stripe, Razorpay
        public string EventType { get; set; } = null!; // invoice.paid, invoice.payment_failed, etc.
        public string? ExternalEventId { get; set; }
        public string Payload { get; set; } = null!;
        public DateTime ReceivedAtUtc { get; set; }
        public DateTime? ProcessedAtUtc { get; set; }
        public string Status { get; set; } = null!; // Pending, Processed, Failed
        public string? ErrorMessage { get; set; }

        public Workspace? Workspace { get; set; }
    }
}
