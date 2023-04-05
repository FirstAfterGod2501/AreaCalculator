using AreaCalculator.Model;

namespace Tests;

public class TriangleTests
{
    [Test]
    public void PassingTest()
    {
        var calculator = new AreaCalculator.AreaCalculator();
        Assert.That(calculator.CalculateSquare(new Triangle(5,5,6)),Is.EqualTo(12));
    }

    [Test]
    public void CheckForNull()
    {
        var calculator = new AreaCalculator.AreaCalculator();
        Assert.Throws<ArgumentException>(() =>
        {
            calculator.CalculateSquare(new Triangle(0,5,5));
        });    }

    [Test]
    public void CheckForOverflow()
    {
        var calculator = new AreaCalculator.AreaCalculator();
        Assert.That(calculator.CalculateSquare(new Triangle(double.MaxValue, double.MaxValue, double.MaxValue)),
            Is.EqualTo(double.PositiveInfinity));
    }

    [Test]
    public void CheckForNegative()
    {
        var calculator = new AreaCalculator.AreaCalculator();
        Assert.Throws<ArgumentException>(() =>
        {
            calculator.CalculateSquare(new Triangle(-1,5,5));
        });
    }
}