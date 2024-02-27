using Catalog.Domain.Aggregates;
using Catalog.Domain.Common;

namespace Catalog.Domain.Events
{
    public sealed class CatalogItemCreatedEvent(CatalogItem item) : BaseEvent
    {
        public CatalogItem Item { get; init; } = item;
    }
}
