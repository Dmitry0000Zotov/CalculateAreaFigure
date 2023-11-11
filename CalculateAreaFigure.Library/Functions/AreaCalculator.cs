using CalculateAreaFigure.Library.Interfaces;

namespace CalculateAreaFigure.Library.Functions
{
    /// <summary>
    /// Класс, реализующий вычисление площади фигуры
    /// </summary>
    public static class AreaCalculator
    {
        /// <summary>
        /// Метод для рассчета площади фигуры
        /// </summary>
        /// <param name="figure">Объект класса, реализующего интерфейс IFigure</param>
        /// <returns>Значение площади исходной фигуры</returns>
        public static double CalculateArea(IFigure figure)
        {
            return figure.CalculateArea();
        }
    }
}
