
using System.Collections.Generic;
using System;
using MedicalAppoiment.Domain.Base;

namespace MedicalAppoiment.Domain.Entities.Configuration
{
    public sealed class Role : BaseEntity
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
