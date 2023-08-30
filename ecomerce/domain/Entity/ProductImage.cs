using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductImage : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        public int? ProductId { get; set; } // from product model


    }
}
