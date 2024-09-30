
using System.Collections.Generic;
using System;
using MedicalAppoiment.Domain.Base;

namespace MedicalAppoiment.Domain.Entities.Configuration
{
    public sealed class InsuranceProvider : BaseEntity
    {
        public int InsuranceProviderId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string CoverageDetails { get; set; }
        public string LogoUrl { get; set; }
        public bool IsPreferred { get; set; }
        public NetworkType NetworkType { get; set; }
        public string CustomerSupportContact { get; set; }
        public string AcceptedRegions { get; set; }
        public decimal? MaxCoverageAmount { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
