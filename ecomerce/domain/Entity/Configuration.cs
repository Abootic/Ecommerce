using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Configuration : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }





    }

}

