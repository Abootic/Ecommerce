

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ProductAttributeDto 
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? AttributeId { get; set; }
        public string? Name { get; set; }
        public int? AttributeItemId { get; set; }
        


    }

}
