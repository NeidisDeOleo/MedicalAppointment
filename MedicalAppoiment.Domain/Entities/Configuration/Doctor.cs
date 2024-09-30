
namespace MedicalAppoiment.Domain.Entities.Configuration
{
    public sealed class Doctor : User
    {
        public Specialty Specialty { get; set; }
        public string LicenseNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int YearsOfExperience { get; set; }
        public string Education { get; set; }
        public string Bio { get; set; }
        public decimal? ConsultationFee { get; set; }
        public string ClinicAddress { get; set; }
        public AvailabilityMode AvailabilityMode { get; set; }
    }
}
