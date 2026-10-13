using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class MessagePricing
    {
        public int MessagePricingId { get; set; }
        public string CountryCode { get; set; } = null!; // IN, US, etc.
        public string Category { get; set; } = null!; // marketing, utility, service, auth
        public decimal MetaCostPerMessage { get; set; }
        public DateTime EffectiveFromUtc { get; set; }
        public DateTime? EffectiveToUtc { get; set; }
        public bool IsActive { get; set; }
    }
}
