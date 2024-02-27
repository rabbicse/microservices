using Catalog.Domain.Common;
using Catalog.Domain.Enums;
using Catalog.Domain.Interfaces;
using School.Domain.ValueObjects;

namespace Catalog.Domain.Aggregates
{
    public class CatalogItem : BaseEntity, IAggregateRoot
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public CatalogType? ItemType { get; set; }
        public CatalogBrand? Brand { get; set; } 
    }
}
