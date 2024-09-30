

using System.Collections.Generic;
using System;
using MedicalAppoiment.Domain.Base;

namespace MedicalAppoiment.Domain.Entities.Configuration
{
    public class Specialty : BaseEntity
    {
        public short SpecialtyId { get; set; }
        public string SpecialtyName { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
