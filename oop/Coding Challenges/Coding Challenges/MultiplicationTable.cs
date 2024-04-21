using System;

namespace Coding_Challenges
{
    internal class MultiplicationTable
    {
    
        internal MultiplicationTable()
        {
            Console.WriteLine("\nMultiplication Table\n");
            Table(IntInput(), IntInput());
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

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }

        private void Table(int multiplied, int multiplier)
        {
            for (int i = 1; i <= multiplier; i++)
                Console.WriteLine($"{multiplied} x {i} = {multiplied * i}");

        }

    }
}
