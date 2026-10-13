using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class MessageUsage
    {
        public long UsageId { get; set; }
        public long WorkspaceId { get; set; }
        public long? SubscriptionId { get; set; }
        public DateTime PeriodStartUtc { get; set; }
        public DateTime PeriodEndUtc { get; set; }

        public int TotalWhatsAppMessages { get; set; }
        public int TotalWhatsAppMessagesMarketing { get; set; }
        public int TotalWhatsAppMessagesUtility { get; set; }
        public int TotalWhatsAppMessagesService { get; set; }
        public int TotalWhatsAppMessagesAuth { get; set; }

        public decimal EstimatedWhatsAppCost { get; set; }
        public DateTime LastUpdatedUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
        public WorkspaceSubscription? Subscription { get; set; }
    }
}
