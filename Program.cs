using System;

abstract class Shape
{
    public abstract int GetArea();
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int GetArea()
    {
        return Width * Height;
    }
}

class Square : Shape
{
    public int Side { get; set; }

    public override int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Робота з прямокутником
        Rectangle rectangle = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");

        // Робота з квадратом
        Square square = new Square { Side = 5 };
        Console.WriteLine($"Square area: {square.GetArea()}");

        Console.ReadKey();
    }
}
