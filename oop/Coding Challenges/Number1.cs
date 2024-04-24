/*Write a C# program that contains method that accepts inputs from the user 
- that will compute the sum of two integers and two doubles separately, and
after showing the result of the two sums, compute for the product of the sums 
- the result must be a double data type.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int firstInt, secondInt;
        double firstDouble, secondDouble;

        while (true)
        {
            try
            {
                Console.WriteLine("Enter two integers");
                Console.Write("1: ");
                firstInt = Convert.ToInt32(Console.ReadLine());
                Console.Write("2: ");
                secondInt = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter two doubles");
                Console.Write("1: ");
                firstDouble = Convert.ToDouble(Console.ReadLine());
                Console.Write("2: ");
                secondDouble = Convert.ToDouble(Console.ReadLine());

                break;
            }
            catch
            {
                Console.WriteLine("Invalid input. Please try again.\n");
            }
        }
        int intSum = firstInt + secondInt;
        double doubleSum = firstDouble + secondDouble;

        Console.WriteLine("\nSum of two integers: " + intSum);
        Console.WriteLine("Sum of two doubles: " + doubleSum);

        double product = intSum * doubleSum;
        Console.WriteLine("Product of the sums: " + product);
    }
}