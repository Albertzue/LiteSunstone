using LiteSunstone.Domain;

namespace LiteSunstone.Persistance
{
    public class DataInMemory
    {
        private IEnumerable<Patient> patients { get; set; }
        public DataInMemory()
        {
            patients = new List<Patient> {
                new Patient("1","Lisa", 66),
                 new Patient("1","Peter", 86),
                  new Patient("1","Jack", 96),
                };
        }

        public IEnumerable<Patient> GetPatients()
        {
            return patients;
        }
    }
}