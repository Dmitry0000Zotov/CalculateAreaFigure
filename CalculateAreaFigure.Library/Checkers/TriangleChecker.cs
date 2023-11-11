using CalculateAreaFigure.Library.Models;

namespace CalculateAreaFigure.Library.Checkers
{
    /// <summary>
    /// Класс реализующий проверки для треугольника
    /// </summary>
    public static class TriangleChecker
    {
        /// <summary>
        /// Проверка треугольника на прямоугольность
        /// </summary>
        /// <param name="triangle">Объект класса Triangle</param>
        /// <returns>Результат проверки на прямоугольность (true/false)</returns>
        public static bool IsRightTriangleCheck(Triangle triangle)
        {
            double maxSide = Math.Max(Math.Max(triangle.SideA, triangle.SideB), triangle.SideC);

            double sumOfSquares;
            if (maxSide == triangle.SideA)
            {
                sumOfSquares = triangle.SideB * triangle.SideB + triangle.SideC * triangle.SideC;
            }
            else if (maxSide == triangle.SideB)
            {
                sumOfSquares = triangle.SideA * triangle.SideA + triangle.SideC * triangle.SideC;
            }
            else
            {
                sumOfSquares = triangle.SideA * triangle.SideA + triangle.SideB * triangle.SideB;
            }

            return maxSide * maxSide == sumOfSquares;
        }

        /// <summary>
        /// Проверка треугольника на прямоугольность
        /// </summary>
        /// <param name="sideA">Первая сторона треугольника</param>
        /// <param name="sideB">Вторая сторона треугольника</param>
        /// <param name="sideC">Третья сторона треугольника</param>
        /// <returns>Результат проверки на прямоугольность (true/false)</returns>
        public static bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            double maxSide = Math.Max(Math.Max(sideA, sideB), sideC);

            double sumOfSquares;
            if (maxSide == sideA)
            {
                sumOfSquares = sideB * sideB + sideC * sideC;
            }
            else if (maxSide == sideB)
            {
                 sumOfSquares = sideA * sideA + sideC * sideC;
            }
            else
            {
                sumOfSquares = sideA * sideA + sideB * sideB;
            }

            return maxSide * maxSide == sumOfSquares;
        }
    }
}
