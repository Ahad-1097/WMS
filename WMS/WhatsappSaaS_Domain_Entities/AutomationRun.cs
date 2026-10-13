using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class AutomationRun
    {
        public long AutomationRunId { get; set; }
        public long AutomationId { get; set; }
        public long WorkspaceId { get; set; }
        public long ContactId { get; set; }
        public string? TriggerDataJson { get; set; }
        public string Status { get; set; } = null!; // Scheduled, Executed, Skipped, Failed
        public DateTime ScheduledAtUtc { get; set; }
        public DateTime? ExecutedAtUtc { get; set; }

        public Automation Automation { get; set; } = null!;
        public Workspace Workspace { get; set; } = null!;
        public Contact Contact { get; set; } = null!;
    }
}
