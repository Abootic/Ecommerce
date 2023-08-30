using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class CouponItem : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }

        public int? CouponId { get; set; }
        public string? ItemId { get; set; }  //   productId 

        public string Type { get; set; } // type for itemId  if is product 
    }

}
