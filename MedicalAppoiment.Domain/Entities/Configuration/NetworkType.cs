
using System.Collections.Generic;
using System;
using MedicalAppoiment.Domain.Base;

namespace MedicalAppoiment.Domain.Entities.Configuration
{
    public sealed class NetworkType : BaseEntity
    {
        public int NetworkTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<InsuranceProvider> InsuranceProviders { get; set; }
    }
}
