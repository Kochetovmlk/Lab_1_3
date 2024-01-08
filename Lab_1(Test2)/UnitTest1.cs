using NUnit.Framework;

[TestFixture]
public class FigureTests
{
    [Test]
    public void PerimeterCalculator_Triangle_CalculatesPerimeterCorrectly()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 4);
        Point p3 = new Point(3, 0);

        Figure triangle = new Figure(p1, p2, p3);

        double expectedPerimeter = 12.0;
        double actualPerimeter = triangle.PerimeterCalculator();

        Assert.AreEqual(expectedPerimeter, actualPerimeter, 0.001);
    }

    // Добавьте другие тестовые методы по аналогии
}