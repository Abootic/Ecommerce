using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class AddProductToFavorite : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
     
        public int? ProductId { get; set; } // from Product Model
        public string? UserId { get; set; } // from user Model


    }
}
