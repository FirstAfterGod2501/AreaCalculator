using AreaCalculator.Interfaces;


namespace AreaCalculator.Model;

public class Triangle : IFigure
{
    private double A { get; }

    private double B { get; }

    private double C { get; }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double GetSquare()
    {
  
        if (!(A > 0) || !(B > 0) || !(C > 0) && !double.IsInfinity(A*B*C)) throw new ArgumentException();
        var triangle = new List<double>{ A, B, C };
        triangle.Sort();
        if (Math.Abs(Math.Pow(triangle[0],2) + Math.Pow(triangle[1],2) - Math.Pow(triangle[2],2)) < 1e-7)
        {
            return triangle[0] * triangle[2]/2;  // right triangle
        }
        var p = (A + B + C)/2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}