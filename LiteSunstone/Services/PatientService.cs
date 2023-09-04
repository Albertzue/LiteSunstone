using LiteSunstone.Domain;
using MongoDB.Driver;

namespace LiteSunstone.Api.Services
{
    public class PatientService: IPatientService
    {
        private readonly IMongoDatabase database;
        private readonly IMongoCollection<Patient> patientCollection;
        public PatientService(IMongoDatabase database) 
        {
            this.database = database;
            patientCollection = database.GetCollection<Patient>("patients");
        }

        public IEnumerable<Patient> GetPatients() 
        {
            return patientCollection.Find<Patient>(_ => true).ToList();
        }

        public Patient GetPatient(string id) 
        {
            return patientCollection.Find<Patient>(d => d.Id == id).FirstOrDefault();
        }

        public async Task AddPatient(Patient patient)
        {
            var existPatient = GetPatient(patient.Id);
            if (existPatient == null)
            {
                await patientCollection.InsertOneAsync(patient);
            }
            else
            {
                throw new ArgumentException("patientId existing");
            }
        }

        public async Task DeletePatient(string id)
        {
            await patientCollection.DeleteOneAsync(d=>d.Id ==id);
        }
    }
}
