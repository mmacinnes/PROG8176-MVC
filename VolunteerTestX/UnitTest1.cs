using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Volunteer.Controllers;

namespace VolunteerTestX;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // A Sample Unit Test
        
        // Arrange
            var mock = new Mock<ILogger<HomeController>>();
            ILogger<HomeController> logger = mock.Object;
            var hc = new HomeController(logger);

        // Act
            var result = hc.Index();

        // Assert
           Assert.IsType<ViewResult>(result);
    }
}