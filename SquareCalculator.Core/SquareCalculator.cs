using SquareCalculator.Core.Entities;
using SquareCalculator.Core.Factory;

namespace SquareCalculator.Core;

/// <summary>
/// Калькулятор площади фигуры.
/// </summary>
public static class SquareCalculator
{
    /// <summary>
    /// Вычислить площадь для фигуры.
    /// </summary>
    /// <param name="figure">Объект фигуры.</param>
    /// <returns>Значение площади.</returns>
    public static double CalculateSquare(IFigure figure) => figure.CalculateSquare();

    /// <summary>
    /// Вычислить площадь для круга
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    /// <returns>Значение площади.</returns>
    public static double CalculateCircle(double radius)
    {
        var circle = FigureFactory.CreateCircle(radius);

        return circle.CalculateSquare();
    }

    /// <summary>
    /// Вычислить площадь для треугольника.
    /// </summary>
    /// <param name="a">Первая сторона треугольника.</param>
    /// <param name="b">Вторая сторона треугольника.</param>
    /// <param name="c">Третья сторона треугольника.</param>
    /// <returns>Значение площади.</returns>
    public static double CalculateTriangle(double a, double b, double c)
    {
        var triangle = FigureFactory.CreateTriangle(a, b, c);

        return triangle.CalculateSquare();
    }
}
