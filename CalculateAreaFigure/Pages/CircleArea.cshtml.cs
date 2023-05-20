using AreaCalculatorLibrary.Implementations;
using AreaCalculatorLibrary.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculateAreaFigure.Pages
{
    public class CircleAreaModel : PageModel
    {
        public double CircleArea { get; set; } = 0;

        public string Message { get; set; } = null;
        public void OnGet()
        {
        }

        public void OnPost(double radius)
        {
            if(radius > 0)
            {
                Circle circle = new Circle()
                {
                    Radius = radius
                };

                CircleArea = CalculateArea.CalculateAreaCircle(circle);
            }

            Message = "Invalid data.";
        }
    }
}
