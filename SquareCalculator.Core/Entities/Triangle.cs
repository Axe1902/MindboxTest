namespace SquareCalculator.Core.Entities;

/// <summary>
/// Класс описывающий треугольник
/// </summary>
public class Triangle : IFigure
{
    /// <summary>
    /// Первая сторона треугольника.
    /// </summary>
    public double A 
    { 
        get => _a;
        set 
        {
            if (!IsValidSides(value, _b, _c))
                throw new ArgumentException("Некорректное значение стороны");

            _a = value;
        } 
    }

    /// <summary>
    /// Вторая сторона треугольника.
    /// </summary>
    public double B
    {
        get => _b;
        set
        {
            if (!IsValidSides(_a, value, _c))
                throw new ArgumentException("Некорректное значение стороны");

            _b = value;
        }
    }

    /// <summary>
    /// Третья сторона треугольника.
    /// </summary>
    public double C
    {
        get => _c;
        set
        {
            if (!IsValidSides(_a, _b, value))
                throw new ArgumentException("Некорректное значение стороны");

            _c = value;
        }
    }

    /// <summary>
    /// Параметризированный конструктор.
    /// </summary>
    /// <param name="a">Первая сторона треугольника.</param>
    /// <param name="b">Вторая сторона треугольника.</param>
    /// <param name="c">Третья сторона треугольника.</param>
    /// <exception cref="ArgumentException"/>
    public Triangle(double a, double b, double c) 
    {
        if (!IsValidSides(a, b, c))
            throw new ArgumentException("Стороны не образуют треугольник");

        _a = a;
        _b = b;
        _c = c;
    }

    /// <summary>
    /// Вычислить площадь треугольника.
    /// </summary>
    /// <returns>Площадь треугольника.</returns>
    public double CalculateSquare()
    {
        double p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    /// <summary>
    /// Является ли треугольник прямоугольным.
    /// </summary>
    /// <returns>true - является. false - не является.</returns>
    public bool IsRectangular()
    {
        double[] sides = { A, B, C };
        
        Array.Sort(sides);

        var firstCatheter = sides[0];
        var secondCatheter = sides[1];
        var hypotenuse = sides[2];

        return hypotenuse * hypotenuse == firstCatheter * firstCatheter + secondCatheter * secondCatheter;
    }

    /// <summary>
    /// Проверка на валидность стророн треугольника
    /// </summary>
    /// <param name="a">Первая сторона треугольника.</param>
    /// <param name="b">Вторая сторона треугольника.</param>
    /// <param name="c">Третья сторона треугольника.</param>
    /// <returns>true - валидны. false - не валидны.</returns>
    private bool IsValidSides(double a, double b, double c)
        => a + b > c && a + c > b && b + c > a;


    private double _a;
    private double _b;
    private double _c;
}
