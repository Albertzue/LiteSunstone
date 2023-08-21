using System.Xml.Linq;

namespace LiteSunstone.Domain.UnitTest
{
    public class PatientTest
    {
        public class ConstructorShould
        {
            [Fact]
            public void ReturnPatientWhenArguementIsRight()
            {
                //arrange && act
                var id = "id";
                var name = "name";
                var age = 88;
                var patient = new Patient(id, name, age);

                //assert
                Assert.NotNull(null);
                Assert.Equal(patient.Id, id);
                Assert.Equal(patient.Name, name);
                Assert.Equal(patient.Age, age);
            }
        }
    }
}