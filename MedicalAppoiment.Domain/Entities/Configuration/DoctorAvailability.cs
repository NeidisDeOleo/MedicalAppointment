
using MedicalAppoiment.Domain.Base;
using System;

namespace MedicalAppoiment.Domain.Entities.Configuration
{

    public sealed class DoctorAvailability
    {
        public int AvailabilityId { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AvailableDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
