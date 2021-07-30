using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Api.Messages;

namespace Catalog.Api
{
    public sealed class CatalogItem
    {
        public Guid Id { get; }
        public string Name { get; }
        public decimal Price { get; set; }
        public int Quantity { get; }

        public CatalogItem(CreateItemCommand cmd)
        {

        }
    }
}
