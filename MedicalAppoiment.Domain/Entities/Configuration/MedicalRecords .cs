

using MedicalAppoiment.Domain.Base;
using System;

namespace MedicalAppoiment.Domain.Entities.Configuration
{
    public sealed class MedicalRecord : BaseEntity
    {
        public int RecordId { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime DateOfVisit { get; set; }
    }

}
