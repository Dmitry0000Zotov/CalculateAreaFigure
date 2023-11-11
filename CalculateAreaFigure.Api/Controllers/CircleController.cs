using CalculateAreaFigure.Library.Functions;
using CalculateAreaFigure.Library.Interfaces;
using CalculateAreaFigure.Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculateAreaFigure.Api.Controllers
{
    [Route("figures/[controller]/[action]")]
    public class CircleController : Controller
    {
        /// <summary>
        /// Рассчет площади окружности
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <returns>Площадь исходной окружности</returns>
        [HttpGet]
        public ActionResult<double> CalculateArea(double radius)
        {
            IFigure circle = new Circle(radius);
            var area = AreaCalculator.CalculateArea(circle);

            return Ok(area);
        }
    }
}
