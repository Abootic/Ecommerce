using System;
using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class Coupon : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Rate { get; set; }
        public string? ApplyTo { get; set; }
        public double? QtRequire { get; set; }
        public double? PriceRequire { get; set; }
        public string? Type { get; set; }
        public string?  Details { get; set; }

    }
}
