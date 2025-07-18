using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Blue", 5);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Purple", 5, 3);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Green", 7);
        shapes.Add(circle1);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}