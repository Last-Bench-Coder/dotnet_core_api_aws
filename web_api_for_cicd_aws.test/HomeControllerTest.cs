using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_api_for_cicd_aws.Controllers;

namespace web_api_for_cicd_aws.test
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void GetNameLength_ReturnsOkResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.GetNameLength("John");

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));

            var okResult = result as OkObjectResult;
            Assert.AreEqual("The length of the given name John is 4", okResult.Value);
        }
    }
}