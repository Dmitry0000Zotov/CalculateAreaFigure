using CalculateAreaFigure.Library.Checkers;
using CalculateAreaFigure.Library.Functions;
using CalculateAreaFigure.Library.Interfaces;
using CalculateAreaFigure.Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculateAreaFigure.Api.Controllers
{
    [Route("figures/[controller]/[action]")]
    public class TriangleController : Controller
    {
        /// <summary>
        /// Расчет площади треугольника
        /// </summary>
        /// <param name="sideA">Первая сторона</param>
        /// <param name="sideB">Вторая сторона</param>
        /// <param name="sideC">Третья сторона</param>
        /// <returns>Площадь исходного треугольника</returns>
        [HttpGet]
        public ActionResult<double> CalculateArea(double sideA, double sideB, double sideC)
        {
            IFigure triangle = new Triangle(sideA, sideB, sideC);
            var area = AreaCalculator.CalculateArea(triangle);
            return Ok(area);
        }

        /// <summary>
        /// Проверка треугольника на прямоугольность
        /// </summary>
        /// <param name="sideA">Первая сторона</param>
        /// <param name="sideB">Вторая сторона</param>
        /// <param name="sideC">Третья сторона</param>
        /// <returns>Результат прроверки треугольника на прямоугольность (true/false)</returns>
        [HttpGet]
        public ActionResult<bool> IsRightTriangleCheck(double sideA, double sideB, double sideC)
        {
            IFigure triangle = new Triangle(sideA, sideB, sideC);

            return Ok(TriangleChecker.IsRightTriangleCheck((Triangle)triangle));
        }
    }
}
