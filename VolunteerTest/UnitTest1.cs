using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Volunteer.Controllers;

namespace VolunteerTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        // Arrange
        var mock = new Mock<ILogger<HomeController>>();
        ILogger<HomeController> logger = mock.Object;
        var hc = new HomeController(logger);

        // Act
        var result = hc.Index() as ViewResult;

        // Assert
        //Assert.IsInstanceOfType(result, ViewResult);
        Assert.IsNotNull(result);

    }
}