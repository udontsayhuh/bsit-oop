using System;

class Program
{
    static void Main(string[] args)
    {
        
        string[] cars = new string[5];

 
        cars[0] = "Chevrolet Bel Air";
        cars[1] = "Ford Model T";
        cars[2] = "Cadillac Eldorado";
        cars[3] = "Dodge Charger (1969)";
        cars[4] = "Chevrolet Corvette (C1)";

        Console.WriteLine("Original list of cars: ");
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }

        
        Array.Sort(cars);

        
        Console.WriteLine("\nSorted list of cars:");
        foreach (string car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
