using AreaCalculatorLibrary.Implementations;
using AreaCalculatorLibrary.Models;

namespace CalculateAreaImplementation.Tests
{
    public class CalculateAreaTests
    {
        [Fact]
        public void CalculateAreaCircleReturnCorrectValue()
        {
            double radius = 5;
            double expectedArea = 78.53981633974483;
            Circle circle = new Circle() { Radius = radius };

            double actualArea = CalculateArea.CalculateAreaCircle(circle);

            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CalculateAreaTriangleReturnCorrectValue()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expectedArea = 6;
            Triangle triangle = new Triangle() { Side1 = side1, Side2 = side2, Side3 = side3 };

            double actualArea = CalculateArea.CalculateAreaTriangle(triangle);

            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CalculateAreaCircleValidValues()
        {
            double radius = -2;

            Circle circle = new Circle() { Radius = radius };

            Assert.Throws<ArgumentException>(() => CalculateArea.CalculateAreaCircle(circle));
        }

        [Fact]
        public void CalculateAreaTriangleValidValues()
        {
            Triangle triangle = new Triangle() { Side1 = 3, Side2 = -4, Side3 = 5 };

            Assert.Throws<ArgumentException>(() => CalculateArea.CalculateAreaTriangle(triangle));
        }
    }
}
