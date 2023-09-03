using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class SubClassificationBase : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string SubClassificationName { get; set; }
        public int? BasicClassificationId { get; set; } // from BasicClassification model
        public string? ImageUrl { get; set; }

        public virtual BasicClassification? BasicClassification { get; set; }
        public virtual ICollection<SubSubclassification> SubSubclassifications { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}