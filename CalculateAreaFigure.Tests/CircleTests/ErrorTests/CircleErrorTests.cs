using CalculateAreaFigure.Library.Models;
using Xunit;

namespace CalculateAreaFigure.Tests.CircleTests.ErrorTests
{
    public class CircleErrorTests
    {
        [Fact(DisplayName = "Проверка ошибки \"ArgumentException\" при создании объекта \"Circle\"")]
        public void Circle_CreateCircle_InvalidCircleException()
        {
            // Arrange
            double radius = -6;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
