using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class SubscriptionEvent
    {
        public long SubscriptionEventId { get; set; }
        public long SubscriptionId { get; set; }
        public string EventType { get; set; } = null!; // Created, PaymentFailed, PaymentSucceeded, etc.
        public string? EventDataJson { get; set; }
        public DateTime OccurredAtUtc { get; set; }

        public WorkspaceSubscription Subscription { get; set; } = null!;
    }
}
