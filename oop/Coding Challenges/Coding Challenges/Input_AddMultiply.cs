using System;

namespace Coding_Challenges
{
    internal class Input_AddMultiply
    {

         internal Input_AddMultiply()
        {
            Console.WriteLine("\nAdd Multiply Int and Double\n");

            int IntSum = Add(IntInput(), IntInput());
            double DoubleSum = Add(DoubleInput(), DoubleInput());

            Console.WriteLine($"\nProduct of Sums = { Convert.ToDouble(IntSum) * DoubleSum}\n");

        }

        private int IntInput()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter an Integer Value: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    return input;

                } catch (FormatException e)
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }

        private double DoubleInput()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a Numeric Double Value: ");
                    double input = Convert.ToDouble(Console.ReadLine());
                    return input;

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }

        private int Add(int x, int y)
        {
            Console.WriteLine($"\n{x} + {y} =  {x + y}\n");
            return x + y;
        }
        private double Add(double x, double y)
        {
            Console.WriteLine($"\n{x} + {y} =  {x + y}\n");
            return x + y;
        }

    }
}
