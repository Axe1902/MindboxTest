using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.Core.Entities;

/// <summary>
/// Инетерфейм описывающий абстрактную фигуру.
/// </summary>
public interface IFigure
{
    /// <summary>
    /// Вычислить площадь фигуры.
    /// </summary>
    /// <returns>Значение площади.</returns>
    public double CalculateSquare();
}
