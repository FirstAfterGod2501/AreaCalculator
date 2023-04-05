using AreaCalculator.Interfaces;

namespace AreaCalculator;

public class AreaCalculator
{
    public double CalculateSquare(IFigure figure)
    {
        return figure.GetSquare();
    }
}
