//Hambiol,Regine Mae G.
//BSIT 2-2

using System;

namespace Calculator
{
    class Program
    {
        // Default Constructor

        static void Main(string[] args)
        {
            do
            {
                double num1 = 0; // Encapsulation: Variables num1, num2, and result are encapsulated within the Main method.
                double num2 = 0;
                double result = 0;

                Console.WriteLine("-----------------------");
                Console.WriteLine("Calculator Activity");
                Console.WriteLine("-----------------------");

                // Accepting input for number 1
                Console.Write("Enter number 1: ");
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;                 }

                // Accepting input for number 2
                Console.Write("Enter number 2: ");
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return; // Encapsulation: Control flow logic is encapsulated within the Main method same as the num1 variable
                }

                // Abstraction: The user interface and calculation logic..
                // Accepting input for operator
                Console.WriteLine("Enter an operation to be used: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an operation to be used: ");
                string operation = Console.ReadLine();

                // Polymorphism: Switch statement allows for different behavior based on the type of operation that the user has chosen.

                // Performing the calculation based on the operator
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        // Abstraction: Handling division by zero is abstracted away from the user.
                        // Check for division by zero
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            return; // Encapsulation: Control flow logic if the cannot divide by zero…
                        }
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid operation.");
                        return; // Encapsulation: Control flow logic if the operation is invalid.
                }

                // Asking the user to continue or exit
                Console.Write("Would you like to continue? (Y = yes, N = no): ");
            } while (Console.ReadLine().ToUpper() == "Y" || Console.ReadLine().ToUpper() == "yes") || Console.ReadLine().ToUpper() == "YES");

            Console.WriteLine("Thank you for using the calculator!!!");
            Console.ReadKey();
        }
    }
}