using Catalog.Domain.Common;

namespace School.Domain.ValueObjects
{
    public class CatalogBrand : ValueObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Country { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
        }
    }
}
