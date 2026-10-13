using System;
using System.Collections.Generic;

namespace WhatsappSaaS.Domain.Entities
{
    public class WorkspaceSubscription
    {
        public long SubscriptionId { get; set; }
        public long WorkspaceId { get; set; }
        public int PlanId { get; set; }
        public string Status { get; set; } = null!; // Active, PastDue, Cancelled, Expired, Trialing
        public DateTime CurrentPeriodStartUtc { get; set; }
        public DateTime CurrentPeriodEndUtc { get; set; }
        public bool AutoRenew { get; set; }
        public string? ExternalSubscriptionId { get; set; }
        public string? ExternalCustomerId { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime UpdatedAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
        public Plan Plan { get; set; } = null!;
        public ICollection<SubscriptionEvent> SubscriptionEvents { get; set; } = new List<SubscriptionEvent>();
        public ICollection<MessageUsage> MessageUsages { get; set; } = new List<MessageUsage>();
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
