

namespace TestingJH_LAB1
{
    public class UnitTest1
    {
        //private readonly TrucksController _trucksController;
        //private readonly Mock<ITruckRepository> _productRepositoryMock;

        /*
        [Fact]
        public void Test1()
        {
            //Arrange - what do you want to test?
            Product p = new Product { Name = "Test" };

            //Act
            string value = p.Name;

            //Asssert
            Assert.Equal("Test", value);

        }
        */

        [Fact]
        public void Test2()
        {
            //Arrange
            var stack = new Stack<string>();
            var value = "Hello, Unit Test";
            stack.Push(value);

            //Act
            string result = stack.Pop();

            //assert
            Assert.Equal(value, result);
        }
    }
}