using AreaCalculatorLibrary.Implementations;
using AreaCalculatorLibrary.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculateAreaFigure.Pages
{
    public class TraingleAreaModel : PageModel
    {
        public double TriangleArea { get; set; } = 0;

        public bool IsRight { get; set; } = false;

        public string Message { get; set; } = null;
        public void OnGet()
        {
        }

        public void OnPost(double side1, double side2, double side3)
        {
            if (side1 > 0 && side2 > 0 && side3 > 0)
            {
                Triangle triangle = new Triangle()
                {
                    Side1 = side1,
                    Side2 = side2,
                    Side3 = side3
                };

                TriangleArea = CalculateArea.CalculateAreaTriangle(triangle);
                IsRight = triangle.CheckRightTriangle();
            }

            Message = "Invalid data.";
        }
    }
}
