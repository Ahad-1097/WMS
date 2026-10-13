using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class BillingProviderCustomer
    {
        public long BillingCustomerId { get; set; }
        public long WorkspaceId { get; set; }
        public string Provider { get; set; } = null!; // Stripe, Razorpay
        public string ExternalCustomerId { get; set; } = null!;
        public bool IsPrimary { get; set; }
        public DateTime CreatedAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
    }
}
