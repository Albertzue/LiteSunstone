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

        public async void AddPatient(Patient patient)
        {
            await patientCollection.InsertOneAsync(patient);
        }
    }
}
