/*Write a C# program that contains method that accepts inputs from the user 
- that will compute the sum of two integers and two doubles separately, and
after showing the result of the two sums, compute for the product of the sums 
- the result must be a double data type.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        //declarations
        int firstInt, secondInt;
        double firstDouble, secondDouble;

        while (true)//will ask the user to input untill inputs are valid
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
        int intSum = firstInt + secondInt;// adds the two integer
        double doubleSum = firstDouble + secondDouble;// adds the two double

        //displays the sums
        Console.WriteLine("\nSum of two integers: " + intSum);
        Console.WriteLine("Sum of two doubles: " + doubleSum);

        double product = intSum * doubleSum;//multiplies the sum of the two integer and double
        Console.WriteLine("Product of the sums: " + product);// displays the product of the sums of two integer and double
    }
}