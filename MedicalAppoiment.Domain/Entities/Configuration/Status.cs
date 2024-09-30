
using System.Collections.Generic;

namespace MedicalAppoiment.Domain.Entities.Configuration
{
    public sealed class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
