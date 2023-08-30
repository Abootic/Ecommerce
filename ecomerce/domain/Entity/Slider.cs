using System;
using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Slider : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string? Details { get; set; }
        public string? Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
     
       
     

  

    }

}
