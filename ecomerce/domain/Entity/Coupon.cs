using System;
using EcommereceWeb.Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Coupon : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Rate { get; set; }
        public string? ApplyTo { get; set; }/// <summary>
        /// why is string and what did you mean
        /// </summary>
        public double? QtRequire { get; set; }/// <summary>
        /// why is double
        /// </summary>
        public double? PriceRequire { get; set; }//
        public string? Type { get; set; }
        public string?  Details { get; set; }
        
        public virtual ICollection<CouponItem> CouponItems { get; set; }


    }
}
