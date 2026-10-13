namespace WhatsappSaaS.Domain.Entities
{
    public class ContactTagLink
    {
        public long ContactId { get; set; }
        public long ContactTagId { get; set; }

        public Contact Contact { get; set; } = null!;
        public ContactTag ContactTag { get; set; } = null!;
    }
}
