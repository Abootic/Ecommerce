using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class SubSubclassification : AuditableEntity, IBaseEntity<int>
    {

        public int Id { get; set; }
        public string SubSubClassificationName { get; set; } 
        public int? SubclassificationId { get; set; } // from  Subclassification model
        public string ImageUrl { get; set; }



       
        }
}
