namespace GeometryCalculator;

/// <summary>
/// Интерфейс для фигур, поддерживающих вычисление площади.
/// Позволяет расширять библиотеку новыми фигурами.
/// </summary>
public interface IShape
{
    /// <summary>
    /// Вычисляет площадь фигуры.
    /// </summary>
    /// <returns>Площадь в квадратных единицах.</returns>
    double CalculateArea();
}