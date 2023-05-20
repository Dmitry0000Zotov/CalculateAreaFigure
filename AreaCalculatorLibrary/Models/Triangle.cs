using System;

namespace AreaCalculatorLibrary.Models
{
    public class Triangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public bool CheckRightTriangle()
        {
            double hypotenuse = Math.Max(Math.Max(Side1, Side2), Side3);

            if(hypotenuse == Side1)
            {
                return Side1 * Side1 == Side2 * Side2 + Side3 * Side3;
            }
            else if(hypotenuse == Side2)
            {
                return Side2 * Side2 == Side1 * Side1 + Side3 * Side3;
            }
            else
            {
                return Side3 * Side3 == Side1 * Side1 + Side2 * Side2;
            }
        }
    }
}
