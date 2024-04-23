using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenges
{
    class Sum
    {
        double number1;
        double number2;
        int intSum;
        double doubleSum;

        public void UserInputNumbers()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    number1 = Convert.ToDouble(Console.ReadLine());

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Enter second number: ");
                            number2 = Convert.ToDouble(Console.ReadLine());
                            
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Must be numeric");
                        }

                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Must be numberic");
                }
                
            }
        }


        // method to calculate the sum of integer numbers
        public void CalculateSum(int num1, int num2)
        {
            intSum = num1 + num2;

            Console.WriteLine("\nSum of two integers: ", sum);
        }

        // method to calculate the sum of double numbers
        public void Calculate Sum(double num1, double num2)
        {
            double sum = num1 + num2;

            Console.WriteLine("\nSum of two double: ", sum);
        }

        public void CalculateProduct()
        {
            double product = intSum * doubleSum;

            Console.WriteLine("\nProduct of the sums: ", product);
        }

    }
}
