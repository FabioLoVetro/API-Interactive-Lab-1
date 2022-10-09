using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CocktailControllerTests
    {
        // this attribute tells NUnit to run this method as a test
        [Test]
        public void TestGetCocktail()
        {
            // ARRANGE - we set up everything needed for our test
            string expectedContent = "It's time to drink something";

            var controller = new CocktailController();
            // ACT - we perform the test
            var result = controller.Get();
            // ASSERT - we compare the result to the expected result

            Assert.AreEqual(expectedContent, result);
        }
    }
}