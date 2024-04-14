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
        public List<dynamic> AllValues = new List<dynamic>();    // List to store the values of operands (declared as dynamic to store any data type).
        public double Result;

        // Constructor
        public Calculator(List<dynamic> allValues, double result)
        {
            AllValues = allValues;
            Result = result;
        }

        // Abstract method.
        public abstract double Calculate();   // Method for calculation.
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
        }

        public static void DisplayResult(double result)
        {
            if (!Double.IsInfinity(result)) // Check and execute if the result is not infinity.
            {
                Console.Write($"{result}\n");
            }
            else
            {
                Console.Write("Cannot divide by 0!\n");
            }
        }
    }

    // Create another class called UserInput
    class UserInput
    {
        public static List<dynamic> GetUserInput()
        {
            List<dynamic> values = new List<dynamic>(); // List to store all the values that the user input (declared as dynamic to store any data type).
            char chosenOperator = ' ';

            while (chosenOperator != '=')   // Loop as long as the user does not enter an equal sign for the operator. (Outer loop)
            {
                // Error handling.
                while (true)    // First inner loop.
                {
                    try // Execute and test for errors, if any occurs handle them with cath statement.
                    {
                        Console.Write("\nEnter number for Operand: ");
                        values.Add(Convert.ToDouble(Console.ReadLine()));  // Add the user input to the list of values.
                        Display.DisplayAllValuesInput(values); // Method call to DisplayAllValuesInput method in the Display class with parameter values(list).
                        break;  // Exit the while loop.
                    }
                    catch (Exception e)
                    {   // Execute this statement if the user input is not a number.
                        Display.DisplayAllValuesInput(values); // Method call to DisplayAllValuesInput method in the Display class with parameter values(list).
                        Console.Write("\n\nInvalid input! Please input a valid value!");
                    }
                }   // End of first inner loop.

                Console.Write("\nEnter operator: ");
                chosenOperator = Convert.ToChar(Console.Read());

                // Validate the chosen operator.
                while (chosenOperator != '+' && chosenOperator != '*' && chosenOperator != '-' && chosenOperator != '/' && chosenOperator != '=')   // Second inner loop.
                {
                    Console.ReadLine();
                    Display.DisplayAllValuesInput(values); // Method call to DisplayAllValuesInput method in the Display class with parameter values(list).

                    Console.Write("\n\nInvalid operator!\nEnter valid operator (+, *, -, /, =): ");
                    chosenOperator = Convert.ToChar(Console.Read());
                }   // End of second inner loop.
                Console.ReadLine();
                values.Add(chosenOperator);    // Add the user input for the operator to the list of values.

                if (chosenOperator != '=')  // Check and execute if the chosenOperator is not an equal sign.
                {
                    Display.DisplayAllValuesInput(values);     // Method call to DisplayAllValuesInput method in the Display class with parameter values(list).
                }
            }   // End of outer loop.
            return values;  // Return the list that the user input for the values to the calling method.
        }
    }

    // Create another class called BasicCalcualtor that inherits from the "Calculator".
    class BasicCalculator : Calculator
    {
        public BasicCalculator(List<dynamic> allValues, double result) : base(allValues, result) { }

        // Implementation of abstract method from "Calculator" class (Polymorphism as well).
        public override double Calculate()
        {
            //list:  1 + 8 / 3 *  10  / 5 - 96   *   5  /   3    =
            //index: 0 1 2 3 4 5  6   7 8 9 10  11  12  13  14  15
            //list:  7 =
            //list:  1 + 6 / 0 * 5 / 2 =
            for (int i = 0; i != AllValues.Count - 1; i += 2)  // Continue looping until the last index has been reached (indicating termination).
            {
                if (i != 0) // This statement is the one that always gets executed after the first loop.
                {
                    if (!Double.IsInfinity(Result)) // Check and execute if the result is not infinity.
                    {
                        switch (AllValues[i])
                        {
                            case '+': Result += AllValues[i + 1]; break;
                            case '*': Result *= AllValues[i + 1]; break;
                            case '-': Result -= AllValues[i + 1]; break;
                            case '/': Result /= AllValues[i + 1]; break;
                        }
                    }
                    else
                    {   // Execute this if the result is infinity(indicating that the entire list has value "/ 0") to stop the calculation since no need to calculate the remaining values.
                        break;  // Exit the for loop.
                    }
                }
                else
                {   // This statement will only execute once. And this is the first statement to be executed.
                    if (AllValues[i + 1] != '=')  // Check and execute if the value of the second element in the list is not '='.
                    {
                        switch (AllValues[i + 1])
                        {
                            case '+': Result = AllValues[0] + AllValues[2]; break;
                            case '-': Result = AllValues[0] - AllValues[2]; break;
                            case '*': Result = AllValues[0] * AllValues[2]; break;
                            case '/': Result = AllValues[0] / AllValues[2]; break;
                        }
                    }
                    else
                    {
                        Result = AllValues[i];  // Assign the value of first element to Result since the value of second element is "=".
                        break;  // Exit the for loop.
                    }
                    i += 1; // Increment i by 1.
                }
            }
            return Result;  // Return the result to the calling method.
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char anotherCalcu = 'Y';
            while (anotherCalcu == 'Y')
            {   // Loop as long as the value of anotherCalcu is 'Y' (outer loop).
                Display.DisplayOperationOption();   // Diplay operation option using the DisplayOperationOption method from the Display class.
                List<dynamic> valuesInput = UserInput.GetUserInput();   // Method call to GetUserInput method from the UserInput class, then assign the return value to valuesInput(list).
                Display.DisplayAllValuesInput(valuesInput); // Diplay all values that the user input (including operations) using the DisplayAllValuesInput method from the Display class.

                // Create an instance of the BasicCalculator class with a list of user input values and an initial result of 0.0.
                BasicCalculator calculateValues = new BasicCalculator(valuesInput, 0.0);

                // Method call to Calculate method then the result of the calculation is passed as an argument to call the DisplayResult method.
                Display.DisplayResult(calculateValues.Calculate());

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