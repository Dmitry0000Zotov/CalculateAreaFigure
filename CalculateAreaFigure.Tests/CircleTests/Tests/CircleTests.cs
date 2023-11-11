using CalculateAreaFigure.Library.Functions;
using CalculateAreaFigure.Library.Models;
using Xunit;

namespace CalculateAreaFigure.Tests.CircleTests.Tests
{
    public class CircleTests
    {
        [Fact(DisplayName = "Успешное вычисление площади окружности")]
        public void Circle_CalculateArea_SuccessCalculation()
        {
            // Arrange
            double radius = 6;
            double expectedArea = 113.1;
            Circle circle = new Circle(radius);

            // Act 
            double calculatedArea = AreaCalculator.CalculateArea(circle);

            // Assert
            Assert.Equal(expectedArea, calculatedArea, 2);
        }
    }
}
