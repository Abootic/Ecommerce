using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class SubSubclassification : AuditableEntity, IBaseEntity<int>
    {

        public int Id { get; set; }
        public string SubSubClassificationName { get; set; } 
        public int? SubClassificationBaseId { get; set; } // from  Subclassification model
        public string ImageUrl { get; set; }
        public virtual SubClassificationBase? SubClassificationBases { get; set; }
        public virtual ICollection<Product> Products { get; set; }




    }
}
