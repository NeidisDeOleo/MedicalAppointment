
using System;

namespace MedicalAppoiment.Domain.Base
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            this.IsActive = false;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
