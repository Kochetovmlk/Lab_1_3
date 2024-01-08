using System;

public class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Figure
{
    private Point[] points;

    public string Name { get; set; }

    public Figure(params Point[] figurePoints)
    {
        if (figurePoints.Length < 3 || figurePoints.Length > 5)
        {
            throw new ArgumentException("A figure must have 3 to 5 points.");
        }

        points = figurePoints;
    }

    private double LengthSide(Point A, Point B)
    {
        int dx = A.X - B.X;
        int dy = A.Y - B.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public double PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += LengthSide(points[i], points[i + 1]);
        }
        perimeter += LengthSide(points[points.Length - 1], points[0]); // Замыкаем фигуру.
        return perimeter;
    }
}

class Program
{
    static void Main()
    {
        // Пример использования класса Figure
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 4);
        Point p3 = new Point(3, 0);

        Figure triangle = new Figure(p1, p2, p3);
        triangle.Name = "Треугольник";

        Console.WriteLine($"Название фигуры: {triangle.Name}");
        Console.WriteLine($"Периметр: {triangle.PerimeterCalculator()}");
    }
}