
namespace CalculateAreaFigure.Library.Interfaces
{
    /// <summary>
    /// Интерфейс для геометрических фигур, предоставляющий метод для расчета площади.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Метод для рассчета площади фигуры
        /// </summary>
        /// <returns>Значение площади исходной фигуры</returns>
        double CalculateArea();
    }
}
