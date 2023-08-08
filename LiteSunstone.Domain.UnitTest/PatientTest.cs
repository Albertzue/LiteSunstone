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
                var patient = new Patient("id","name",88);

                //assert
                Assert.NotNull(patient);
            }
        }
    }
}