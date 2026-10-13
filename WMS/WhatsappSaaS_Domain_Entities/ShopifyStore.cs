using System;

namespace WhatsappSaaS.Domain.Entities
{
    public class ShopifyStore
    {
        public long ShopifyStoreId { get; set; }
        public long WorkspaceId { get; set; }
        public string ShopDomain { get; set; } = null!;
        public string? AccessTokenEncrypted { get; set; }
        public string? Scope { get; set; }
        public bool IsActive { get; set; }
        public DateTime InstalledAtUtc { get; set; }
        public DateTime? UninstalledAtUtc { get; set; }

        public Workspace Workspace { get; set; } = null!;
    }
}
