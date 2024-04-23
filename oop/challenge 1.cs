// CODING CHALLENGE NO. 1 
// APRIL 20, 2024

using System;

class Program
{
    static void Main(string[] args)
    {
        int int1;
        int int2;
        double double1;
        double double2;

        Console.Write("Enter an integer: ");
        int1 = int.Parse(Console.ReadLine());

        Console.Write("Enter an integer: ");
        int2 = int.Parse(Console.ReadLine());

        Console.Write("Enter a double: ");
        double1 = double.Parse(Console.ReadLine());

        Console.Write("Enter a double: ");
        double2 = double.Parse(Console.ReadLine());

        int intsum = int1 + int2;
        Console.WriteLine($"The sum of two integers is: {intsum}");

        double dblsum = double1 + double2;
        Console.WriteLine($"The sum of two doubles is: {dblsum}");

        double product = dblsum * intsum;
        Console.WriteLine($"The product of the two sums: {product}");
    }
}
