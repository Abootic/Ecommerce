using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductUnitSize : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public bool? ProductType { get; set; }
        public int? ProductId { get; set; } // from product model


    }
}
