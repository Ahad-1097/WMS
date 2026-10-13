using System;
using System.Collections.Generic;

namespace WhatsappSaaS.Domain.Entities
{
    public class Campaign
    {
        public long CampaignId { get; set; }
        public long WorkspaceId { get; set; }
        public string Name { get; set; } = null!;
        public byte ChannelType { get; set; } // WhatsApp
        public string TemplateName { get; set; } = null!;
        public string SegmentFilterJson { get; set; } = null!;
        public string Status { get; set; } = null!; // Draft, Scheduled, Sending, Completed, Paused, Failed
        public int TotalRecipients { get; set; }
        public DateTime? ScheduledAtUtc { get; set; }
        public long CreatedByUserId { get; set; }
        public DateTime CreatedAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
        public User CreatedByUser { get; set; } = null!;
        public ICollection<CampaignMessage> CampaignMessages { get; set; } = new List<CampaignMessage>();
    }
}
