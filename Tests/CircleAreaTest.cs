using AreaCalculator.Model;

namespace Tests;

public class CircleTests
{
    [Test]
    public void PassingTest()
    {
        var calculator = new AreaCalculator.AreaCalculator();
        Assert.That(calculator.CalculateSquare(new Circle(4d)), Is.EqualTo(Math.PI * Math.Pow(4,2)));
    }

    [Test]
    public void CheckForNull()
    {
        var calculator = new AreaCalculator.AreaCalculator();
        Assert.That(calculator.CalculateSquare(new Circle(0)), Is.EqualTo(0));
    }

    [Test]
    public void CheckForOverflow()
    {
        var calculator = new AreaCalculator.AreaCalculator();
        Assert.That(calculator.CalculateSquare(new Circle(double.MaxValue)), Is.EqualTo(double.PositiveInfinity));
    }

    [Test]
    public void CheckForNegative()
    {
        var calculator = new AreaCalculator.AreaCalculator();
        Assert.Throws<ArgumentException>(() =>
        {
            calculator.CalculateSquare(new Circle(-1d));
        });
    }
}