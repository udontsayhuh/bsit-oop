using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter the first integer: ");
        int int1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int int2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the first double: ");
        double double1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second double: ");
        double double2 = Convert.ToDouble(Console.ReadLine());

        
        int sumIntegers = int1 + int2;
        double sumDoubles = double1 + double2;

       
        Console.WriteLine("Sum of integers: " + sumIntegers);
        Console.WriteLine("Sum of doubles: " + sumDoubles);

       
        double product = sumIntegers * sumDoubles;
        Console.WriteLine("Product of sums: " + product);
    }
}
