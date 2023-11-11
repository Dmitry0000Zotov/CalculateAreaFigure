using CalculateAreaFigure.Library.Interfaces;

namespace CalculateAreaFigure.Library.Models
{
    /// <summary>
    /// Класс окружности, реализующий интерфейс IFigure
    /// </summary>
    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (!IsValidCircle(radius))
                throw new ArgumentException("Invalid radius of cicle");
            Radius = radius;
        }

        /// <summary>
        /// Метод для расчета площади окружности по ее радиусу
        /// </summary>
        /// <returns>Площадь исходной окружности</returns>
        public double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }

        /// <summary>
        /// Проверка радиуса окружности на правильность
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <returns>Результат проверки радиуса (true/false)</returns>
        private bool IsValidCircle(double radius)
        {
            return radius > 0;
        }
    }
}
