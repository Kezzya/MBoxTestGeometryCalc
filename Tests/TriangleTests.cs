using GeometryCalculator;
using Xunit;

namespace GeometryCalculator.Tests;

public class TriangleTests
{
    [Fact]
    public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
    {
        var triangle = new Triangle(3, 4, 5);
        double expectedArea = 6; // Площадь по формуле Герона
        Assert.Equal(expectedArea, triangle.CalculateArea(), precision: 10);
    }

    [Fact]
    public void IsRightAngled_RightTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5); // Прямоугольный треугольник (3² + 4² = 5²)
        Assert.True(triangle.IsRightAngled());
    }

    [Fact]
    public void IsRightAngled_NonRightTriangle_ReturnsFalse()
    {
        var triangle = new Triangle(2, 3, 4); // Не прямоугольный
        Assert.False(triangle.IsRightAngled());
    }

    [Fact]
    public void Constructor_NegativeSide_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-1, 2, 3));
    }

    [Fact]
    public void Constructor_InvalidTriangle_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3)); // Не выполняется условие треугольника
    }
}