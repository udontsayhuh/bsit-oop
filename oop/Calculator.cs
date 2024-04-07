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

        public void DisplayAllValuesInputted()
        {
            Console.Clear();    // Clear the console screen.
            DisplayOperationOption();   // Method call to DisplayOperationOption method.
            foreach (dynamic val in Operand) { Console.Write($"{val} "); }  // Display all the values stored in the list called Operand.
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
            while (chosenOperator != '=')   // Loop as long as the user does not enter an equal sign for the operator.
            {
                // Error handling.
                while (true)
                {
                    try // Execute and test for errors, if any occurs handle them with cath statement.
                    {
                        Console.Write("Enter number for Operand: ");
                        Operand.Add(Convert.ToDouble(Console.ReadLine()));  // Add the user inputted to the list of Operand.
                        DisplayAllValuesInputted(); // Method call to DisplayAllValuesInputted method.
                        break;
                    }
                    catch (Exception e)
                    {   // Execute this statement if the user inputted is not a number.
                        DisplayAllValuesInputted(); // Method call to DisplayAllValuesInputted method.
                        Console.WriteLine("Invalid input! Please input a valid value!");
                    }
                }

                Console.Write("Enter operator: ");
                chosenOperator = Convert.ToChar(Console.Read());

                // Validate the chosen operator.
                while (chosenOperator != '+' && chosenOperator != '*' && chosenOperator != '-' && chosenOperator != '/' && chosenOperator != '=')
                {
                    Console.ReadLine();
                    DisplayAllValuesInputted(); // Method call to DisplayAllValuesInputted method.

                    Console.Write("Invalid operator!\nEnter valid operator (+, *, -, /, =): ");
                    chosenOperator = Convert.ToChar(Console.Read());
                }
                Console.ReadLine();
                Operand.Add(chosenOperator);    // Add the user inputted for the operator to the list of Operand.
                DisplayAllValuesInputted();     // Method call to DisplayAllValuesInputted method.
            }
            Console.Clear();    // Clear the console scree.
            DisplayOperationOption();   // Diplay operation option using the DisplayOperationOption method.
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
                Console.Clear();    // Clear the console screen.
            }   // End of outer loop.
            Console.WriteLine("Program end!");
        }
    }
}