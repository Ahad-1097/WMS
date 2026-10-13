using System;
using System.Collections.Generic;

namespace WhatsappSaaS.Domain.Entities
{
    public class Plan
    {
        public int PlanId { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public string Currency { get; set; } = "USD";
        public int BillingPeriodInDays { get; set; }
        public decimal MonthlyPrice { get; set; }
        public int IncludedWhatsAppMessages { get; set; }
        public int MaxWhatsAppMessagesPerMonth { get; set; }
        public decimal? OveragePricePerMessage { get; set; }
        public bool AllowOverage { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public bool IsActive { get; set; }

        public ICollection<WorkspaceSubscription> Subscriptions { get; set; } = new List<WorkspaceSubscription>();
        public ICollection<PlanWhatsAppCategoryLimit> WhatsAppCategoryLimits { get; set; } = new List<PlanWhatsAppCategoryLimit>();
    }
}
