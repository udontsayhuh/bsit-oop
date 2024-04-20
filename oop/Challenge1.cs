/* Write a C# program that contains method that accepts inputs from the user - that will
compute the sum of two integers and two doubles separately, and after showing the
result of the two sums, compute for the product of the sums - the result must be a
double data type. */

using System;

    class Program{

    static void Main(string[] args) {

    Console.WriteLine("Enter an integer");
    int int1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter an integer");
    int int2 = Convert.ToInt32(Console.ReadLine());

    int sumOfInt = int1 + int2;
    Console.WriteLine($"{int1} + {int2} = {sumOfInt}\n");

    Console.WriteLine("Enter an double");
    double double1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter an double");
    double double2 = Convert.ToDouble(Console.ReadLine());

    double sumOfDouble = double1 + double2;
    Console.WriteLine($"{double1} + {double2} = {sumOfDouble}\n");
    
    double productOfSums = sumOfInt * sumOfDouble;
    Console.WriteLine($"{sumOfInt} * {sumOfDouble} = {productOfSums}");
    }
}
