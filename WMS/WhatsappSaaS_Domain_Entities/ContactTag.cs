using System;
using System.Collections.Generic;

namespace WhatsappSaaS.Domain.Entities
{
    public class ContactTag
    {
        public long ContactTagId { get; set; }
        public long WorkspaceId { get; set; }
        public string Name { get; set; } = null!;

        public Workspace Workspace { get; set; } = null!;
        public ICollection<ContactTagLink> ContactTagLinks { get; set; } = new List<ContactTagLink>();
    }
}
