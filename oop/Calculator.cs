using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //Create abstract class called "Calculator".
    abstract class Calculator
    {
        // Attributes
        public double[] Operand;    // Array to store the value of operands.
        public double Result;

        // Constructor
        public Calculator(double[] operand, double result)
        {
            Operand = operand;
            Result = result;
        }

        // Abstract method.
        public abstract void UserInput();   // Method for user input.
        public abstract void Calculate(char chosenOperator);    // Method for calculation.

        // Regular Method.
        public void DisplayOperationOption()
        {
            Console.WriteLine("──────────────────────────────────────────────────────");
            Console.WriteLine("                     CALCULATOR                       ");
            Console.WriteLine("──────────────────────────────────────────────────────");
            Console.WriteLine("──────────────────────────────────────────────────────");
            Console.WriteLine("| ADDITION ║ MULTIPLICATION ║ SUBTRACTION ║ DIVISION |");
            Console.WriteLine("──────────────────────────────────────────────────────");
            Console.WriteLine("|    +     ║       *        ║      -      ║     /    |");
            Console.WriteLine("──────────────────────────────────────────────────────");
        }
    }

    // Create another class called BasicCalcualtor that inherits from the "Calculator".
    class BasicCalculator : Calculator
    {
        public BasicCalculator(double[] operand, double result) : base(operand, result) { }

        // Implementation of abstract method from "Calculator" class (Polymorphism as well).
        public override void UserInput()
        {
            // Error handling.
            try // Execute and test for errors, if any occurs handle them with catch statement.
            {
                Console.Write("Enter number for Operand 1: ");
                Operand[0] = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {   // Execute this statement if the user inputted is not a number.
                Console.WriteLine("Invalid input! Now terminating the program!");
                Environment.Exit(0);
            }

            Console.Write("Enter operator: ");
            char chosenOperator = Convert.ToChar(Console.Read());

            // Validate the chosen operator.
            while (chosenOperator != '+' && chosenOperator != '*' && chosenOperator != '-' && chosenOperator != '/')
            {
                Console.ReadLine();
                Console.Clear();    // Clear the console scree.
                DisplayOperationOption();   // Diplay operation option using the DisplayOperationOption method.
                Console.WriteLine($"Enter number for Operand 1: {Operand[0]}");
                Console.Write("\nInvalid operator!\nEnter valid operator (+, *, -, /): ");
                chosenOperator = Convert.ToChar(Console.Read());
            }

            // Error handling.
            try
            {   // Execute and test for errors, if any occurs handle them with catch statement.
                Console.ReadLine();
                Console.Write("Enter number for Operand 2: ");
                Operand[1] = Convert.ToDouble(Console.ReadLine());
                if (Operand[1] == 0)
                {
                    Console.WriteLine("Cannot divide by 0!");
                }
                else
                {
                    Calculate(chosenOperator);  // Call to Calculate method with parameter of chosenOperator.
                }
            }
            catch (Exception e)
            {   // Execute this statement if the user inputted is not a number.
                Console.WriteLine("Invalid input! Now terminating the program!");
                Environment.Exit(0);
            }
        }
        public override void Calculate(char chosenOperator)
        {
            switch (chosenOperator)
            {
                case '+': Result = Operand[0] + Operand[1]; break;
                case '*': Result = Operand[0] * Operand[1]; break;
                case '-': Result = Operand[0] - Operand[1]; break;
                case '/': Result = Operand[0] / Operand[1]; break;
            }
            Console.WriteLine($"{Operand[0]} {chosenOperator} {Operand[1]} = {Result}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char anotherCalcu = 'Y';
            while (anotherCalcu == 'Y')
            {   // Loop as long as the value of anotherCalcu is 'Y' (outer loop).
                // Create a new array of double with two elements initialized to 0.0 then passed it as an argument to the constructor of BasicCalculator.
                BasicCalculator calculateValues = new BasicCalculator(new double[] { 0.0, 0.0 }, 0.0);
                calculateValues.DisplayOperationOption();   // Diplay operation option using the DisplayOperationOption method.
                calculateValues.UserInput();    // Get the user input for operands and operator using the UserInput method.

                // Ask user if the user want to perform another calculation.
                Console.Write("Do you want another calculation again? (Y/N): ");
                anotherCalcu = Char.ToUpper(Convert.ToChar(Console.Read()));    // Get the value of anotherCalcu variable then convert it to uppercase.
                Console.ReadLine();

                // Validate the user choice.
                while (anotherCalcu != 'Y' && anotherCalcu != 'N')
                { // Inner loop.
                    Console.Write("\nInvalid choice!\nEnter a valid choice (Y/N): ");
                    anotherCalcu = Char.ToUpper(Convert.ToChar(Console.Read()));
                    Console.ReadLine();
                }   // End of inner loop.
                Console.Clear();    // Clear the console scree.
            }   // End of outer loop.
            Console.WriteLine("Program end!");
        }
    }
}