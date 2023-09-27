using AreaCalculator.Interfaces;

namespace AreaCalculator.Figures;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetSquare()
    {
        if (_radius >= 0)
        {
            return Math.PI * Math.Pow(_radius, 2d);
        }

        throw new ArgumentException("invalid radius");
    }
}