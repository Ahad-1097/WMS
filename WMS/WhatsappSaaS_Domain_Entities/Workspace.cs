using System;
using System.Collections.Generic;

namespace WhatsappSaaS.Domain.Entities
{
    public class Workspace
    {
        public long WorkspaceId { get; set; }
        public string Name { get; set; } = null!;
        public long OwnerUserId { get; set; }
        public string? TimeZone { get; set; }
        public string? CountryCode { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public bool IsActive { get; set; }

        public User? OwnerUser { get; set; }
        public ICollection<WorkspaceMember> Members { get; set; } = new List<WorkspaceMember>();
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
        public ICollection<ContactTag> ContactTags { get; set; } = new List<ContactTag>();
        public ICollection<ChannelConnection> ChannelConnections { get; set; } = new List<ChannelConnection>();
        public ICollection<Conversation> Conversations { get; set; } = new List<Conversation>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<Automation> Automations { get; set; } = new List<Automation>();
        public ICollection<AutomationRun> AutomationRuns { get; set; } = new List<AutomationRun>();
        public ICollection<Campaign> Campaigns { get; set; } = new List<Campaign>();
        public ICollection<WorkspaceSubscription> Subscriptions { get; set; } = new List<WorkspaceSubscription>();
        public ICollection<MessageUsage> MessageUsages { get; set; } = new List<MessageUsage>();
        public ICollection<MessageUsageDaily> MessageUsageDaily { get; set; } = new List<MessageUsageDaily>();
        public ICollection<BillingProviderCustomer> BillingProviderCustomers { get; set; } = new List<BillingProviderCustomer>();
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
        public ICollection<IncomingWebhook> IncomingWebhooks { get; set; } = new List<IncomingWebhook>();
        public ICollection<ShopifyStore> ShopifyStores { get; set; } = new List<ShopifyStore>();
        public ICollection<WordPressSite> WordPressSites { get; set; } = new List<WordPressSite>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
        public ICollection<BillingWebhookEvent> BillingWebhookEvents { get; set; } = new List<BillingWebhookEvent>();
    }
}
