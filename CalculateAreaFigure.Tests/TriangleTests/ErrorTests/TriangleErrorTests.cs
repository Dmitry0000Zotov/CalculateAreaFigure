using Xunit;
using CalculateAreaFigure.Library.Models;
using CalculateAreaFigure.Library.Functions;
using CalculateAreaFigure.Library.Checkers;
using System.ComponentModel;

namespace CalculateAreaFigure.Tests.TriangleTests.ErrorTests
{
    public class TriangleErrorTests
    {
        [Fact(DisplayName = "Проверка ошибки \"ArgumentException\" при создании объекта \"Triangle\"")]
        public void Triangle_CreateTriangle_InvalidTriangleException()
        {
            // Arrange
            double sideA = 1.0;
            double sideB = 2.0;
            double sideC = 3.0;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
    }
}
