namespace LiteSunstone.Persistance.UnitTest
{
    public class DataInMemoryTests
    {
        public class GetPatientsShould
        {
            [Fact]
            public void ReturnPatients()
            {
                //arrange
                var dataInMemory = new DataInMemory();

                //act
                var patients = dataInMemory.GetPatients();

                //assert
                Assert.True(patients.Any());
            }
        }
    }
}