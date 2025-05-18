using System;

namespace GeometryCalculator;

/// <summary>
/// Круг.
/// </summary>
public class Circle : IShape
{
    private readonly double _radius;

    /// <summary>
    /// Создает круг с указанным радиусом.
    /// </summary>
    /// <param name="radius">Радиус круга (должен быть неотрицательным).</param>
    /// <exception cref="ArgumentException">Если радиус меньше 0.</exception>
    public Circle(double radius)
    {
        if (radius < 0)
            throw new ArgumentException("Radius must be non-negative.", nameof(radius));
        _radius = radius;
    }

    /// <inheritdoc />
    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}