using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Product : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }

        public string ProductName { get; set; }
        public string Name { get; set; }
        // كود  المنتج  عند  مشاركة المنتج يتم ارساله هذا الكود  ليتمكن من البحث عبره
        public string Code { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int? Quantity { get; set; }

        public string Logo { get; set; }// الصورة الرئيسة للمنتج
        public string? Details { get; set; }
        public decimal? MinOrderQuantity { get; set; } // اقل كمية يتم  طلبة
        public string? VideoProvider { get; set; }// نوع مزود الخدمة  هل يوتيوب او غيرة 
        public string? VideoUrl { get; set; }
        public string? TaxType { get; set; }// نوع الضريبة  هل قيمة او نسبة مئوية
        public string? TaxValue { get; set; }// قيمة الضريبة

        public string? KeyWords { get; set; }
       
        public int? BrandId { get; set; }//العلامة  التجارية
      // from brand model
        public int? MainClassificationId { get; set; }
        //from MainClassfication model
        public int? BasicClassificationId { get; set; }
        // from BasicClassification model
        public int? SubclassificationId { get; set; }
        // from Subclassification model
        public int? SubSubClassificationId { get; set; }
        // from SubSubClassification model




    }
}
