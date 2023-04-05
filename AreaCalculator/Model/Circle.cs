using AreaCalculator.Interfaces;

namespace AreaCalculator.Model;


public class Circle : IFigure
{
    private double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetSquare()
    {
        if (Radius >= 0)
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
        throw new ArgumentException();
    }
}