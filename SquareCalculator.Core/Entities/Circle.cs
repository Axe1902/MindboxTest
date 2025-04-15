using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.Core.Entities;

/// <summary>
/// Класс описывающий круг.
/// </summary>
public class Circle : IFigure
{
    /// <summary>
    /// Параметризированный конструктор.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    public Circle(double radius) 
    {
        if (radius <= 0)
            throw new ArgumentException("Значение радиуса не может быть отрицательным.");

        _radius = radius;
    }

    /// <summary>
    /// Вычислить площадь круга.
    /// </summary>
    /// <returns>Значение площади.</returns>
    public double CalculateSquare()
    {
        return Math.PI * _radius * _radius;
    }

    private readonly double _radius;
}
