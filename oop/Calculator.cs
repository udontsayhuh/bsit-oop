using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //Create abstract class called "Calculator".
    abstract class Calculator
    {
        // Attributes
        public List<dynamic> Operand = new List<dynamic>();    // List to store the values of operands (declared as dynamic to store any data type).
        public double Result;

        // Constructor
        public Calculator(List<dynamic> operand, double result)
        {
            Operand = operand;
            Result = result;
        }

        // Abstract method.
        public abstract void UserInput();   // Method for user input.
        public abstract void Calculate();   // Method for calculation.
    }


    // Create another class called Display
    class Display
    {
        // Regular Method.
        public static void DisplayOperationOption()
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

        public static void DisplayAllValuesInput(List<dynamic> userInputValues)
        {
            Console.Clear();    // Clear the console screen.
            DisplayOperationOption();   // Method call to DisplayOperationOption method.

            // Display all the values that the user's input (including operation).
            for (int i = 0; i < userInputValues.Count; i++)
            {
                Console.Write($"{userInputValues[i]} ");
            }
            Console.WriteLine("\n");
        }
    }

    // Create another class called BasicCalcualtor that inherits from the "Calculator".
    class BasicCalculator : Calculator
    {
        public BasicCalculator(List<dynamic> operand, double result) : base(operand, result) { }

        // Implementation of abstract method from "Calculator" class (Polymorphism as well).
        public override void UserInput()
        {
            char chosenOperator = ' ';
            while (chosenOperator != '=')   // Loop as long as the user does not enter an equal sign for the operator. (Outer loop)
            {
                // Error handling.
                while (true)    // First inner loop.
                {
                    try // Execute and test for errors, if any occurs handle them with cath statement.
                    {
                        Console.Write("Enter number for Operand: ");
                        Operand.Add(Convert.ToDouble(Console.ReadLine()));  // Add the user input to the list of Operand.
                        Display.DisplayAllValuesInput(Operand); // Method call to DisplayAllValuesInput method in the Display class with parameter Operand(list).
                        break;  // Exit the while loop.
                    }
                    catch (Exception e)
                    {   // Execute this statement if the user input is not a number.
                        Display.DisplayAllValuesInput(Operand); // Method call to DisplayAllValuesInput method in the Display class with parameter Operand(list).
                        Console.WriteLine("Invalid input! Please input a valid value!");
                    }
                }   // End of first inner loop.

                Console.Write("Enter operator: ");
                chosenOperator = Convert.ToChar(Console.Read());

                // Validate the chosen operator.
                while (chosenOperator != '+' && chosenOperator != '*' && chosenOperator != '-' && chosenOperator != '/' && chosenOperator != '=')   // Second inner loop.
                {
                    Console.ReadLine();
                    Display.DisplayAllValuesInput(Operand); // Method call to DisplayAllValuesInput method in the Display class with parameter Operand(list).

                    Console.Write("Invalid operator!\nEnter valid operator (+, *, -, /, =): ");
                    chosenOperator = Convert.ToChar(Console.Read());
                }   // End of second inner loop.
                Console.ReadLine();
                Operand.Add(chosenOperator);    // Add the user input for the operator to the list of Operand.
                Display.DisplayAllValuesInput(Operand);     // Method call to DisplayAllValuesInput method in the Display class with parameter Operand(list).
            }   // End of outer loop.
            Console.Clear();    // Clear the console scree.
            Display.DisplayOperationOption();   // Diplay operation option using the DisplayOperationOption method in the Display class.
            Calculate();    // Method call to Calculate method.
        }

        public override void Calculate()
        {
            //list:  1 + 8 / 3 *  10  / 5 - 96   *   5  /   3    =
            //index: 0 1 2 3 4 5  6   7 8 9 10  11  12  13  14  15
            for (int i = 0; Operand[i] != '='; i += 2)  // Continue looping until the equal sign has been reached (indicating termination).
            {
                if (i != 0) // This statement is the one that always gets executed after the first loop.
                {
                    switch (Operand[i])
                    {
                        case '+': Result += Operand[i + 1]; break;
                        case '*': Result *= Operand[i + 1]; break;
                        case '-': Result -= Operand[i + 1]; break;
                        case '/': Result /= Operand[i + 1]; break;
                    }
                }
                else
                {   // This statement will only execute once. And this is the first statement to be executed.
                    if (Operand[i + 1] != '=')  // Check and execute if the value of the second element in the list is not '='.
                    {
                        switch (Operand[i + 1])
                        {
                            case '+': Result = Operand[0] + Operand[2]; break;
                            case '-': Result = Operand[0] - Operand[2]; break;
                            case '*': Result = Operand[0] * Operand[2]; break;
                            case '/': Result = Operand[0] / Operand[2]; break;
                        }
                    }
                    else
                    {
                        break;  // Exit the for loop.
                    }
                    i += 1; // Increment i by 1.
                }
            }
            foreach (dynamic val in Operand) { Console.Write($"{val} "); }  // Display all the values stored in the list of Operand.
            Console.WriteLine($"{Result}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char anotherCalcu = 'Y';
            while (anotherCalcu == 'Y')
            {   // Loop as long as the value of anotherCalcu is 'Y' (outer loop).
                // Create a new list that accept any data type and passed the 0.0 as an argument to the constructor of BasicCalculator.
                BasicCalculator calculateValues = new BasicCalculator(new List<dynamic>(), 0.0);
                Display.DisplayOperationOption();   // Diplay operation option using the DisplayOperationOption method.
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
                Console.Clear();    // Clear the console screen.
            }   // End of outer loop.
            Console.WriteLine("Program end!");
        }
    }
}