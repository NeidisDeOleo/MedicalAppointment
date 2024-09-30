
using MedicalAppoiment.Domain.Base;
using System;

namespace MedicalAppoiment.Domain.Entities.Configuration
{
    public sealed class Appointment : BaseEntity
    {
        public int AppointmentId { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Status Status { get; set; }
    }

}
