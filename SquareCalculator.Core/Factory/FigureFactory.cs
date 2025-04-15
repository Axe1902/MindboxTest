using SquareCalculator.Core.Entities;

namespace SquareCalculator.Core.Factory;

/// <summary>
/// Фабрика для создания фигур.
/// </summary>
public static class FigureFactory
{
    /// <summary>
    /// Создать круг.
    /// </summary>
    /// <param name="radius">Радиус.</param>
    /// <returns>Объект фигуры.</returns>
    public static IFigure CreateCircle(double radius)
        => new Circle(radius);

    /// <summary>
    /// Создать треугольник.
    /// </summary>
    /// <param name="a">Первая сторона треугольника.</param>
    /// <param name="b">Вторая сторона треугольника.</param>
    /// <param name="c">Третья сторона треугольника.</param>
    /// <returns>Объект фигуры.</returns>
    public static IFigure CreateTriangle(double a, double b, double c)
        => new Triangle(a, b, c);
}
