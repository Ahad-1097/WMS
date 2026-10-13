using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class Invoice
    {
        public long InvoiceId { get; set; }
        public long WorkspaceId { get; set; }
        public long? SubscriptionId { get; set; }
        public string? ExternalInvoiceId { get; set; }
        public string Currency { get; set; } = null!;
        public decimal AmountDue { get; set; }
        public decimal AmountPaid { get; set; }
        public string Status { get; set; } = null!; // Draft, Open, Paid, etc.
        public DateTime? PeriodStartUtc { get; set; }
        public DateTime? PeriodEndUtc { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? PaidAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
        public WorkspaceSubscription? Subscription { get; set; }
    }
}
