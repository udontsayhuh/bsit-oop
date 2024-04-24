using System;
class Program
{
    static double num; //declare variables
    static int mul;
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        while (!double.TryParse(Console.ReadLine(), out num)) //loops until valid numerical value is entered 
        {
            Console.WriteLine("Invalid input. Only numerical value is accepted.\n");
            Console.Write("Enter a number: ");
        }

        Console.Write("\nEnter a multiplier: ");
        while (!int.TryParse(Console.ReadLine(), out mul)) //loops until valid integer value is entered 
        {
            Console.WriteLine("Invalid input. Only integer value is accepted.\n");
            Console.Write("Enter a number: ");
        }

        Console.WriteLine("\n");

        for (int i = 1; i <= mul; i++) //loops the multiplier
        {
            double ans = num * i;

            Console.WriteLine($"{num} * {i} = {ans}");
        }

    }
}