using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Model;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        // this attribute tells NUnit to run this method as a test
        [Test]
        public void TestGetCoffeeLover()
        {
            // ARRANGE - we set up everything needed for our test
            string expectedContent = "I like coffee!";
            var controller = new CoffeeController();
            // ACT - we perform the test
            var result = controller.GetLover();
            // ASSERT - we compare the result to the expected result
            Assert.AreEqual(expectedContent, result);
        }
        [Test]
        public void TestGetCoffeeNoParams()
        {
            Coffee expected = new Coffee(-1, "Latte");

            var controller = new CoffeeController();
            var result = controller.Get(null);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
        [Test]
        public void TestGetCoffeeByName()
        {
            string name = "LatteCaffee";
            var controller = new CoffeeController();
            var result = controller.Get(name);

            int id = result.Id;
            Coffee expected = new Coffee(id, name);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}