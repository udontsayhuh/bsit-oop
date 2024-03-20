// Encapsulation
using System;

class Car
{
    private int year;
    private string model;
    private string make;

    public Car(int year, string model, string make)
    {
        this.year = year;
        this.model = model;
        this.make = make;
    }

    public void Display()
    {
        Console.WriteLine($"Car details:\n{model}(model)\n{make}(make)\n{year}(year)")
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car(1997, "Space gear", "Mitsubishi");
        Console.ReadKey();
    }
}
