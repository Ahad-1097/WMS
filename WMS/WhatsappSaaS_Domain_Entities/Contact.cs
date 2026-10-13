using System;
using System.Collections.Generic;

namespace WhatsappSaaS.Domain.Entities
{
    public class Contact
    {
        public long ContactId { get; set; }
        public long WorkspaceId { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; } // E.164
        public string? Email { get; set; }
        public string? InstagramUserId { get; set; }
        public string? FacebookPsid { get; set; }
        public string? Source { get; set; } // Shopify, WP, Chrome, Manual, API
        public string? LeadStage { get; set; } // New, Contacted, Interested, Won, Lost
        public bool OptInWhatsApp { get; set; }
        public string? OptInSource { get; set; }
        public DateTime? OptInDate { get; set; }
        public bool IsUnsubscribedWhatsApp { get; set; }
        public DateTime? UnsubscribedDate { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime UpdatedAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
        public ICollection<Conversation> Conversations { get; set; } = new List<Conversation>();
        public ICollection<ContactTagLink> TagLinks { get; set; } = new List<ContactTagLink>();
        public ICollection<AutomationRun> AutomationRuns { get; set; } = new List<AutomationRun>();
        public ICollection<CampaignMessage> CampaignMessages { get; set; } = new List<CampaignMessage>();
    }
}
