using Task2;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Triangle(3, 5, 1));
        shapes.Add(new Triangle(3, 4, 5));
        shapes.Add(new Circle(5));
        shapes.Add(new Circle(45.4));
        shapes.Add(new Triangle(1.1, 1.1, 1.1));

        foreach (var sh in shapes)
        {
            Console.WriteLine(sh.CalculateArea());
        }

        Console.Read();
    }
}