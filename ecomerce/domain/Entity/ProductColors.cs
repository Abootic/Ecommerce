using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductColors : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public int? ProductId { get; set; } // from product model
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public string? ImgUrl { get; set; }
        public int ColorId { get; set; } // from MasterData model



    }
}
