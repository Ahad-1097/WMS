namespace WhatsappSaaS.Domain.Entities
{
    public class PlanWhatsAppCategoryLimit
    {
        public int PlanWhatsAppCategoryLimitId { get; set; }
        public int PlanId { get; set; }
        public string Category { get; set; } = null!;
        public int IncludedMessages { get; set; }
        public int? MaxMessages { get; set; }
        public decimal? OveragePricePerMessage { get; set; }

        public Plan Plan { get; set; } = null!;
    }
}
