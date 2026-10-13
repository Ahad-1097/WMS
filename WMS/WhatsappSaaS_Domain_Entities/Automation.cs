using System;
using System.Collections.Generic;

namespace WhatsappSaaS.Domain.Entities
{
    public class Automation
    {
        public long AutomationId { get; set; }
        public long WorkspaceId { get; set; }
        public string Name { get; set; } = null!;
        public byte ChannelType { get; set; } // WhatsApp
        public string TriggerType { get; set; } = null!; // NewLead, AbandonedCart, etc.
        public bool IsEnabled { get; set; }
        public string ConfigJson { get; set; } = null!;
        public DateTime CreatedAtUtc { get; set; }
        public DateTime UpdatedAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
        public ICollection<AutomationRun> AutomationRuns { get; set; } = new List<AutomationRun>();
    }
}
