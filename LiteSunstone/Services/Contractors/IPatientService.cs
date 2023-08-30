using LiteSunstone.Domain;

namespace LiteSunstone.Api.Services
{
    public interface IPatientService
    {
        public IEnumerable<Patient> GetPatients();

        public  void AddPatient(Patient patient);
    }
}
