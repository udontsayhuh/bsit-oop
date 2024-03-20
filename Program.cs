using System;

public abstract class Shape
{

    public abstract double Area { get; }
    public abstract double Perimeter { get; }

    // Abstraction: We define abstract methods that every shape must implement
    public abstract void DisplayInfo();
}


public class Circle : Shape
{

    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }


    public override double Area => Math.PI * radius * radius;

    public override double Perimeter => 2 * Math.PI * radius;

    public override void DisplayInfo()
    {
        Console.WriteLine($"Circle with radius {radius}");
        Console.WriteLine($"Area: {Area}");
        Console.WriteLine($"Perimeter: {Perimeter}");
    }
}


public class Rectangle : Shape
{
  
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area => width * height;

    public override double Perimeter => 2 * (width + height);

    public override void DisplayInfo()
    {
        Console.WriteLine($"Rectangle with width {width} and height {height}");
        Console.WriteLine($"Area: {Area}");
        Console.WriteLine($"Perimeter: {Perimeter}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        
        circle.DisplayInfo();
        Console.WriteLine();
        rectangle.DisplayInfo();
    }
} 
