using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class TaxConfiguration : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public int TaxNumber { get; set; }
        public string Value { get; set; }
        public string type { get; set; }
     





    }
}

