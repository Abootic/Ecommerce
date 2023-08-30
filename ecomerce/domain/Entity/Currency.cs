using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Currency : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Simbol { get; set; }
        public string? Value { get; set; }
        public bool IsMain { get; set; }

      
    }

}

