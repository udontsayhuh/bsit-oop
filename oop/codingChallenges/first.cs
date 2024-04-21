using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For input of 2 integer values
            Console.Write("Enter first integer value: ");
            int firstIntegerInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer value: ");
            int secondIntegerInput = Convert.ToInt32(Console.ReadLine());

            // Sum of integer values
            int sumOfIntegers = firstIntegerInput + secondIntegerInput;
            Console.WriteLine("Sum of two integer values: " + sumOfIntegers);

            // For input of 2 double values
            Console.Write("\nEnter first value (double): ");
            double firstDoubleInput = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second value (double): ");
            double secondDoubleInput = Convert.ToDouble(Console.ReadLine());

            // Sum of double values
            double sumOfDoubles = firstDoubleInput + secondDoubleInput;
            Console.WriteLine("Sum of two double values: " + sumOfDoubles);

            // Product of two sums
            double productOfSums = sumOfIntegers * sumOfDoubles;

            Console.WriteLine("The product of two sums is " + productOfSums);
        }
    }
}
