using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class MessageUsageDaily
    {
        public long UsageDailyId { get; set; }
        public long WorkspaceId { get; set; }
        public DateTime UsageDateUtc { get; set; }

        public int WhatsAppMessagesTotal { get; set; }
        public int WhatsAppMessagesMarketing { get; set; }
        public int WhatsAppMessagesUtility { get; set; }
        public int WhatsAppMessagesService { get; set; }
        public int WhatsAppMessagesAuth { get; set; }

        public DateTime CreatedAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
    }
}
