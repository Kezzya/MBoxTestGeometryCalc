using GeometryCalculator;
using Xunit;

namespace GeometryCalculator.Tests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_RadiusZero_ReturnsZero()
    {
        var circle = new Circle(0);
        Assert.Equal(0, circle.CalculateArea());
    }

    [Fact]
    public void CalculateArea_ValidRadius_ReturnsCorrectArea()
    {
        var circle = new Circle(2);
        double expectedArea = Math.PI * 4; // Площадь = π * r²
        Assert.Equal(expectedArea, circle.CalculateArea(), precision: 10);
    }

    [Fact]
    public void Constructor_NegativeRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}