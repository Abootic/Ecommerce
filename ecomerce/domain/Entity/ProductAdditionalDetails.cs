using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductAdditionalDetails : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; } // from product model
        public virtual Product? Product { get; set; }


    }
}
