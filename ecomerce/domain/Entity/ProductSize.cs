using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductSize : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? SizeId { get; set; }




    }
}
