using AreaCalculatorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorLibrary.Implementations
{
    public static class CalculateArea
    {
        public static double CalculateAreaCircle(Circle circle)
        {
            if (circle.Radius <= 0)
                throw new ArgumentException("Radius of the circle should be less than 0");

            return Math.PI * circle.Radius * circle.Radius;
        }

        public static double CalculateAreaTriangle(Triangle triangle)
        {
            if (triangle.Side1 <= 0 || triangle.Side2 <= 0 || triangle.Side3 <= 0)
                throw new ArgumentException("Lengths of the sides of the triangle must be greater 0");

            double semiperimeter = (triangle.Side1 + triangle.Side2 + triangle.Side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - triangle.Side1) * (semiperimeter - triangle.Side2) * (semiperimeter - triangle.Side3));
        }
    }
}
