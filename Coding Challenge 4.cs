using System;

//A program that multiplies two integers and displays its multiplication table
class Multiplication
{
    public static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine()); //integer 1
        int num2 = Convert.ToInt32(Console.ReadLine()); //integer 2

        Console.WriteLine("\nRESULTS: \n");

        //for loop to iterate each multiplication expressions
        for (int i = 1; i <= num2; i++)
        {   
            //to print the result 
            Console.WriteLine("{0} x {1} = {2}", num1, i, num1 * i);
        }
    }
}