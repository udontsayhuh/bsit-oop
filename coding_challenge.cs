using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// OBJECT-ORIENTED PROGRAMMING CODING CHALLENGE ACTIVITY
// NADINE A. BORJA BSIT 2-2 (CODE WITHOUT RESTRICTIONS)

class Program
{
    static void Main(string[] args)
    {

        // coding challenge num1


        // accepts input from the user; in integer
        Console.Write("\t\tINPUT TWO INTEGERS:\n");
        Console.Write("Enter a number: ");
        int intNum1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number: ");
        int intNum2 = Convert.ToInt32(Console.ReadLine());

        int intSum = intNum1 + intNum2; // variable used to compute the input 

        Console.WriteLine("\n\tSUM OF TWO INTEGERS: " + intSum);

        Console.WriteLine("\n");

        // accepts input from the user; in double
        Console.Write("\t\tINPUT TWO DECIMAL NUMBERS:\n");
        Console.Write("Enter a number: ");
        double dobNum1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a number: ");
        double dobNum2 = Convert.ToDouble(Console.ReadLine());

        double doubSum = dobNum1 + dobNum2; // variable used to compute the input 

        Console.WriteLine("\nSUM OF TWO DOUBLES: " + doubSum);

        double product = intSum * doubSum; // computes the product of the sums

        Console.WriteLine("\n" + intSum + " multiplied by " + doubSum + " is eqauls to " + product);


        // coding challenge num2

        Console.Write("Enter your string: ");
        string input = Console.ReadLine();

        int count = 1; // this variable is used to count the characters inside the string
        int i = 0;

        while (i <= input.Length)
        {
            if (input[i] == ' ' || input[i] == '\n' || input[i] == '\t')
            {
                count++;
            }

            i++;
        }

        Console.WriteLine("NUMBER OF WORDS: " + count);
        Console.WriteLine("\nYOUR STRING IS: " + input.ToUpper());


        // coding challenge num3

        do
        {
            Console.Write("\t\tSIMPLE CALCULATOR\n");
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\t\tARITHMETIC FUNCTIONS\n");
            Console.WriteLine("\tADDITION = +");
            Console.WriteLine("\tSUBTRACTION = -");
            Console.WriteLine("\tMULTIPLICATION = *");
            Console.WriteLine("\tDIVISION = /");

            Console.Write("\nEnter symbol:  ");
            string symbol = Console.ReadLine();

            Console.Write("\nEnter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (symbol)
            {
                case "+":
                    Console.WriteLine("ADDITION: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("SUBTRACTION: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("MULTIPLICATION: " + (num1 * num2));
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot be divided.");
                        Console.WriteLine("0");

                    }
                    else
                    {
                        Console.WriteLine("DIVISION: " + (num1 / num2));
                    }
                    break;
                default:
                    Console.WriteLine("Input Incorrect. Select from +, -, *, /.");
                    break;

            }

            Console.WriteLine("\nDo you want to run the program again? (yes/no): ");
            string runAgain = Console.ReadLine().ToLower();

            if (runAgain != "yes" && runAgain != "y")
            {
                Console.WriteLine("Program Closing...");
                break;
            }
        } while (true);


        // coding challenge num4

        Console.Write("\t\tMULTIPLICATION TABLE\n");
        Console.Write("Enter a number (MULTIPLICAND): ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number (MULTIPLIER): ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\n\tMULTIPLICATION TABLE OF " + num1 + "\n");

        for (int i = 1; i <= num2; i++)
        {
            int multiply = num1 * i;
            Console.Write("\t" + num1 + " x " + i + " = " + multiply + "\n");

        }



        // coding challenge num5

        string[] cars = { "Ferrari", "Chevrolet", "Tesla", "Lamborghini", "BMW" };

        Array.Sort(cars);


        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }

        // version 2


        List<string> cars2 = new List<string>();

        //added 5 car (elements) inside the list
        cars2.Add("Ferrari");
        cars2.Add("Chevrolet");
        cars2.Add("Tesla");
        cars2.Add("Lamborghini");
        cars2.Add("BMW");

        Console.WriteLine("\tELEMENTS INSIDE THE LIST (BEFORE SORT): ");
        foreach (var car in cars2)
        {
            Console.Write("\n\t" + car);
        }


        Console.WriteLine("\n\n\tELEMENTS (AFTER SORT): ");

        cars2.Sort();
        foreach (var car in cars2)
        {
            Console.Write("\n\t" + car);
        }

        Console.WriteLine("\n");


















    }
}
