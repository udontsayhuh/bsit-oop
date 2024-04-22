/*Write a C# program that takes two numbers as input: 
the first number will be the number to be multiplied and the second number will be the multiplier, 
and prints its multiplication table up to the given second number (the multiplier).*/

using System;

class Program
{
    public static void Main()
    {
        // integer variable multiplied
        int multiplied;
        
        //do while loop to repeatedly ask the user to enter the number/input until it is a valid integer
        do
        {
            Console.Write("Enter number to be multiplied: ");  //prompt the user to enter a number to be multiplied
            //read user input and attempt to parse it to an integer
            //check to see if the parsing was successful and store the result in the multiplied variable.
            if (!int.TryParse(Console.ReadLine(), out multiplied))
            {
                Console.WriteLine("Invalid input! Please enter an integer.");  //invalid message if user input a invalid value
            }
        } while (multiplied <= 0); //As long as multiplied is equal to or less than 0, continues the loop.

        // integer variable multiplier
        int multiplier;

        //do while loop to repeatedly ask the user to enter the number/input until it is a valid integer
        do
        {
            Console.Write("Enter the multiplier: ");
            //read user input and attempt to parse it to an integer
            //check to see if the parsing was successful and store the result in the multiplier variable.
            if (!int.TryParse(Console.ReadLine(), out multiplier))
            {
                Console.WriteLine("Invalid input! Please enter an integer.");
            }
        } while (multiplier <= 0); //As long as the multiplier is equal to or less than 0, continues the loop.

        Console.WriteLine("\n---------------------------------------------");
        Console.WriteLine("           MULTIPLICATION TABLE");
        Console.WriteLine("              {0} up to {1}", multiplied, multiplier);
        Console.WriteLine("---------------------------------------------");
        
        //for loop to calculate and display the multiplication table
        for (int i = 1; i <= multiplier; i++)
        {
            //calculate the product of multiplied and i, and display it along with the equation.
            Console.WriteLine("{0} x {1} = {2}", multiplied, i, multiplied * i); 
        }
    }
}
