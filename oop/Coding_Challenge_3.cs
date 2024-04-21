using System;

namespace CrystalynDanga
{
    class Program
    {
        /* Write a C# program that can perform basic arithmetic functions. (Addition, Subtraction, Multiplication, and Division). The user must be allowed to select which arithmetic function
he/she wants to use, and then they will be prompted to enter only two numbers after selecting the arithmetic function. Print the result afterwards, and then after printing ask the user if he/she wants toperform another action or not. If yes, repeat the program, if not terminate the program.
*/
        // Method to perform addition
        public static double Add(double value1, double value2)
        {
            double result = value1 + value2;
            Console.WriteLine("The sum is: " + result);
            return result;
        }

        // Method to perform subtraction
        public static double Subtract(double value1, double value2)
        {
            double result = value1 - value2;
            Console.WriteLine("The difference is: " + result);
            return result;
        }

        // Method to perform multiplication
        public static double Multiply(double value1, double value2)
        {
            double result = value1 * value2;
            Console.WriteLine("The product is: " + result);
            return result;
        }

        // Method to perform division
        public static double Divide(double value1, double value2)
        {
            if (value2 == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN; // Return NaN (Not a Number) as a special value for division by zero
            }
            else
            {
                double result = value1 / value2;
                Console.WriteLine("The quotient is: " + result);
                return result;
            }
        }

        // Method to get user's operator choice
        public static char OperatorChoice()
        {
            char choice;
            while (true)
            {
                Console.WriteLine("\nChoose an operator (Enter the symbol)"); // Display operator choices to the user
                Console.WriteLine("1. Add (+)\n2. Subtract (-)\n3. Multiply (*)\n4. Divide (/)");
                Console.Write("\nEnter your choice: "); // Prompt the user to enter their choice

                if (!char.TryParse(Console.ReadLine(), out choice)) // Read user input and attempt to parse it as a character
                {
                    Console.WriteLine("Invalid input."); // Display error message for invalid input
                    continue; // Continue the loop to prompt user again
                }

                // Check if the entered choice is a valid operator
                if (choice == '+' || choice == '-' || choice == '/' || choice == '*' || choice == '=')
                {
                    return choice; // Return the valid operator choice
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid operator!"); // Display error message for invalid operator
                }
            }
        }

        // Method to run the program
        public static void RunProgram()
        {
            while (true)
            {
                Console.Write("Enter first value: ");
                double value1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second value: ");
                double value2 = Convert.ToDouble(Console.ReadLine());

                char choice = OperatorChoice();

                double result = 0;

                // Perform the selected operation
                switch (choice)
                {
                    case '+':
                        result = Add(value1, value2);
                        break;
                    case '-':
                        result = Subtract(value1, value2);
                        break;
                    case '*':
                        result = Multiply(value1, value2);
                        break;
                    case '/':
                        try
                        {
                            result = Divide(value1, value2);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                            break;
                        }
                        break;
                }

                // Ask if the user wants to perform another action
                Console.Write("Do you want to perform another action? (yes/no): ");
                string continueChoice = Console.ReadLine().ToLower();

                if (continueChoice != "yes")
                {
                    break; // Break the loop if the user doesn't want to continue
                }
            }
        }

        static void Main(string[] args)
        {
            RunProgram();
        }
    }
}
