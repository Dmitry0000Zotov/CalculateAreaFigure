using AreaCalculatorLibrary.Models;

namespace CalculateAreaImplementation.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CheckRightTriangleReturnCorrectValue()
        {
            Triangle triangle = new Triangle() { Side1 = 3, Side2 = 4, Side3 = 5 };
            bool expectedValue = true;

            Assert.Equal(expectedValue, triangle.CheckRightTriangle());
        }
    }
}
