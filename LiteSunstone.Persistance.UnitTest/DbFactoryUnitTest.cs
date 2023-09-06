using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteSunstone.Persistance.UnitTest
{
    public class DbFactoryUnitTest
    {
        public class DbFactoryConstructorShould
        {
            [Fact]
            public void ReturnDbFactoryInstance_WhenAgruementsAreValid()
            { 
                //arrange && act
                var factory = new DbFactory("mongodb://localhost:27017", "");

                //assert
                Assert.NotNull(factory);
            }
        }
    }
}
