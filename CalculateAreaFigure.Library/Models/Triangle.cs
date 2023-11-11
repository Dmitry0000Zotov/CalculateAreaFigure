using CalculateAreaFigure.Library.Interfaces;

namespace CalculateAreaFigure.Library.Models
{
    /// <summary>
    /// Класс треугольника, реализующий интерфейс IFigure
    /// </summary>
    public class Triangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC)) 
                throw new ArgumentException("Invalid values on sides triangle");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Метод для расчета площади треугольника по трем сторонам
        /// </summary>
        /// <returns>Площать исходного треугольника</returns>
        public double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;

            return Math.Round(Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC)), 2);
        }

        /// <summary>
        /// Проверка на существование треугольника
        /// </summary>
        /// <param name="sideA">Первая сторона</param>
        /// <param name="sideB">Вторая сторона</param>
        /// <param name="sideC">Третья сторона</param>
        /// <returns>Результат проверки треугольника на существование (true/false)</returns>
        private bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }
    }
}
