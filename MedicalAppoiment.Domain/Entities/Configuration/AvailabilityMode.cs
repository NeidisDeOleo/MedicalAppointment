using MedicalAppoiment.Domain.Base;
using System;
using System.Collections.Generic;

namespace MedicalAppoiment.Domain.Entities.Configuration
{
    public sealed class AvailabilityMode : BaseEntity
    {
        public short AvailabilityModeId { get; set; }
        public string AvailabilityModeName { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
