using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class CampaignMessage
    {
        public long CampaignMessageId { get; set; }
        public long CampaignId { get; set; }
        public long MessageId { get; set; }
        public long ContactId { get; set; }
        public string Status { get; set; } = null!; // Queued, Sent, Failed, Skipped
        public string? ErrorCode { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime CreatedAtUtc { get; set; }

        public Campaign Campaign { get; set; } = null!;
        public Message Message { get; set; } = null!;
        public Contact Contact { get; set; } = null!;
    }
}
