using LiteSunstone.Domain;

namespace LiteSunstone.Api.Services
{
    public interface IPatientService
    {
        public IEnumerable<Patient> GetPatients();

        public  Task AddPatient(Patient patient);

        public Task DeletePatient(string id);
    }
}
