using Xunit;

namespace mekkl.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string city = Faker.Address.City();
            System.Console.WriteLine(city);
            Assert.Equal(city, city);
        }
    }
}
