﻿using System.Diagnostics;
using PublicApiApp.ClientService;

namespace PublicApiApp.Models
{
    public class ClientServiceItem
    {
        public readonly long Id;
        public readonly string Name;

        public ClientServiceItem(ClientService1 clientService)
        {
            // 
            Debug.Assert(clientService.ID.HasValue);
            Id = clientService.ID.Value;
            Name = clientService.Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
