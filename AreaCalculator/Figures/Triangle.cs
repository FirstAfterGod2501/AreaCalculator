using AreaCalculator.Interfaces;

namespace AreaCalculator.Figures;

public class Triangle : IFigure
{
    private readonly double _a;

    private readonly double _b;

    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        var triangle = new List<double> { a, b, c };

        triangle.Sort();

        _a = triangle[0];
        _b = triangle[1];
        _c = triangle[2];
    }

    public double GetSquare()
    {
        if (!IsDataCorrect())
        {
            throw new ArgumentException("Incorrect data");
        }

        return IsRegularTriangle() ? CalculateAreaForRegularTriangle() : CalculateAreaForTriangle();
    }

    private double CalculateAreaForRegularTriangle() => _a * _b / 2;

    private double CalculateAreaForTriangle()
    {
        var p = (_a + _b + _c) / 2;

        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    private bool IsRegularTriangle() =>
        Math.Abs(
            Math.Pow(_a, 2) +
            Math.Pow(_b, 2) -
            Math.Pow(_c, 2)) < 0.02;

    private bool IsDataCorrect() =>
        !(_a > 0) ||
        !(_b > 0) ||
        !(_c > 0) &&
        !double.IsInfinity(_a * _b * _c);
}
