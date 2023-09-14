using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductVariation : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? ProductAttributeId { get; set; }
        public string? ColorName { get; set; }
        public int? ColorId { get; set; }
        public string? SizeName { get; set; }
        public int? SizeId { get; set; }
        public int? Quntatiy { get; set; }
        public decimal? Price { get; set; }

        public virtual ProductAttribute? ProductAttribute { get; set; }
        public virtual Product? Product { get; set; }

    }


}
