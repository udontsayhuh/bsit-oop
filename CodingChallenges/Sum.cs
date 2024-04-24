using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class Sum
    {

        // a method that will display the header
        public void Header()
        {
            Console.Clear(); // will clear the console window

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(" Sum of Integers and Doubles");
            Console.WriteLine("-------------------------------------------------------------\n");
        }

        
        public void InputNumbers()
        {
            Header();
            
            while (true)
            {
                try
                {
                    Console.Write("Enter two integers: ");
                    int intFirstNum = Convert.ToInt32(Console.ReadLine());
                    int intSecondNum = Convert.ToInt32(Console.ReadLine());
                    
                    // ask for double numbers
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Enter two decimal numbers: ");
                            double doubleFirstNum = Convert.ToDouble(Console.ReadLine());
                            double doubleSecondNum = Convert.ToDouble(Console.ReadLine());
                            
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
            
            // calculate the sum of each data type
            int sumOfIntegers = Sum(intFirstNum, intSecondNum);
            double sumOfDoubles = Sum(doubleFirstNum, doubleSecondNum);
            
            // prints the Sums
            Console.WriteLine("The sum of two integer: ", sumOfIntegers);
            Console.WriteLine("The sum of two decimals: ", sumOfDoubles);
            
            // get the product of two sums
            double product = Product(sumOfIntegers, sumOfDoubles);
            // prints the product 
            Console.WriteLine($"The product of {sumOfIntegers} and {sumOfDoubles} is ", product);
        }

        // method to calculate the sum of two integers
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        
        // method to calculate the sum of two doubles 
        public double Sum(double num1, double num2);
        {
            return num1 + num2;
        }
        
        public double Product(int sum1, double sum2)
        {
            return sum1 * sum2;
        }

    }
}
