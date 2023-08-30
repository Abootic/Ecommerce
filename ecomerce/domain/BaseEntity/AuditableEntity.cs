using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.BaseEntity
{
    public class AuditableEntity : ISoftDelete
    {
        public AuditableEntity()
        {
            IsDeleted = false;

        }
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;  
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsDeleted { get ; set; }
        public string? DeletedBy { get ; set ; }
        public DateTime? DeletedAt { get ; set; }
    }

    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
        string? DeletedBy { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}
