using Xunit;
using CalculateAreaFigure.Library.Models;
using CalculateAreaFigure.Library.Functions;
using CalculateAreaFigure.Library.Checkers;
using System.ComponentModel.DataAnnotations;

namespace CalculateAreaFigure.Tests.TriangleTests.Tests
{
    public class TriangleTests
    {
        [Fact(DisplayName = "Успешное вычисление площади треугольника")]
        public void Triangle_CalculateArea_SuccessCalculation()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            double expectedArea = 6.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double calculatedArea = AreaCalculator.CalculateArea(triangle);

            // Assert
            Assert.Equal(expectedArea, calculatedArea);
        }

        [Fact(DisplayName = "Успешная проверка треугольника на прямоугольность")]
        public void Triangle_CheckRight_SuccessCheck()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRight = TriangleChecker.IsRightTriangleCheck(triangle);

            // Assert
            Assert.Equal(true, isRight);
        }
    }
}
