

using System.ComponentModel.DataAnnotations;

namespace EcommereceWeb.Application.DTOs
{
    public class ProductVariationViewDto
    {
     
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? ProductAttributeId { get; set; }
        public string? ColorName { get; set; }
        public int? ColorId { get; set; }
        public string? SizeName { get; set; }
        public int? SizeId { get; set; }
        public int? Quntatiy { get; set; }
        public decimal? Price { get; set; }

       

    }
    public class ProductVariationDto
    {
        [Required]
        [Display(Name = "الرقم")]
        public int Id { get; set; }
        [Display(Name = "رقم المنتج")]
        public int? ProductId { get; set; }
        public int? ProductAttributeId { get; set; }
        [Display(Name = "لون المنتج")]
        public string? ColorName { get; set; }
        public int? ColorId { get; set; }
        [Display(Name = "حجم المنتج")]
        public string? SizeName { get; set; }
        public int? SizeId { get; set; }
        [Display(Name = " الكمية")]
        public int? Quntatiy { get; set; }
        [Display(Name = "=سعر المنتج")]
        public decimal? Price { get; set; }


    }

}
