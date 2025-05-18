using System;

namespace GeometryCalculator;

public class Triangle : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    /// <summary>
    /// Создает треугольник с указанными сторонами.
    /// </summary>
    /// <param name="sideA">Длина первой стороны (должна быть положительной).</param>
    /// <param name="sideB">Длина второй стороны (должна быть положительной).</param>
    /// <param name="sideC">Длина третьей стороны (должна быть положительной).</param>
    /// <exception cref="ArgumentException">Если стороны не образуют треугольник или отрицательны.</exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Sides must be positive.");
        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new ArgumentException("Sides do not form a valid triangle.");

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    /// <inheritdoc />
    public double CalculateArea()
    {
        // Используем формулу Герона
        double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
    }

    /// <summary>
    /// Проверяет, является ли треугольник прямоугольным (с погрешностью для чисел с плавающей точкой).
    /// </summary>
    /// <returns>True, если треугольник прямоугольный, иначе false.</returns>
    public bool IsRightAngled()
    {
        const double tolerance = 1e-10; // Погрешность для чисел с плавающей точкой
        double[] sides = { _sideA, _sideB, _sideC };
        Array.Sort(sides); // Самая длинная сторона (гипотенуза) будет последней

        // Проверяем теорему Пифагора: a² + b² = c²
        return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < tolerance;
    }

    private static bool IsValidTriangle(double a, double b, double c)
    {
        // Условие существования треугольника: сумма любых двух сторон больше третьей
        return a + b > c && b + c > a && a + c > b;
    }
}