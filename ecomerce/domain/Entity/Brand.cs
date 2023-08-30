using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Brand : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string? CompanyInfo { get; set; }

        public string? ImageUrl { get; set; }
       
      
    }
}
