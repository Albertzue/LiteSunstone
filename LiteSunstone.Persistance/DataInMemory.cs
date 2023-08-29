using LiteSunstone.Domain;

namespace LiteSunstone.Persistance
{
    public class DataInMemory
    {
        private IEnumerable<Patient> patients { get; set; }
        public DataInMemory()
        {
            patients = new List<Patient> {
                new Patient("5","Lisa", 66),
                 new Patient("6","Peter", 86),
                  new Patient("7","Jack", 96),
                };
        }

        public IEnumerable<Patient> GetPatients()
        {
            return patients;
        }
    }
}