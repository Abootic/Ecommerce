using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class CouponItem : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }

        public int? CouponId { get; set; }
        public string? ProductId { get; set; }  //   productId 

        public string Type { get; set; } // type for itemId  if is product 

        public virtual Product? Products { get; set; }
        public virtual Coupon? Coupons { get; set; }


    }

}
