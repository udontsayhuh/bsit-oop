using System;

namespace Calculator
{
    class Program//Methods are encapsulated in the Program class.
    {
        static void Main(string[] args)
        {
            while (true) //Will continue to get user input when 'y' is entered unless user inputs 'n'.
            {
                Console.Write("\nEnter the first number: ");
                string userInput1 = Console.ReadLine();
                if (double.TryParse(userInput1, out double firstNumber)) //Will try to convert user input into a double.
                                                                         //If successful, the input is a number.
                                                                         //If not, the input is not a number.
                {
                    while (true)//Will continue to ask for user input unless +, -, * or / is entered.
                    {
                        Console.Write("\nOperator (+, -, *, /): ");
                        string operatr = Console.ReadLine();
                        if (operatr == "+" || operatr == "-" || operatr == "*" || operatr == "/") //Checks for valid operator.
                        {
                            while (true)
                            {
                                Console.Write("\nEnter the second number: ");
                                string userInput2 = Console.ReadLine();
                                if (double.TryParse(userInput2, out double secondNumber))//Will try to convert user input into a double.
                                                                                         //If successful, the input is a number.
                                                                                         //If not, the input is not a number.
                                {
                                    double result = 0;
                                    //Abstraction - only asks the user for inputs and hides the how's of getting the result to the user.
                                    switch (operatr)//Calculates for the result based on number inputs and operator chosen.
                                    {
                                        case "+":
                                            result = firstNumber + secondNumber;
                                            Console.WriteLine($"\n{firstNumber} + {secondNumber} = " + result);
                                            break;
                                        case "-":
                                            result = firstNumber - secondNumber;
                                            Console.WriteLine($"\n{firstNumber} - {secondNumber} = " + result);
                                            break;
                                        case "*":
                                            result = firstNumber * secondNumber;
                                            Console.WriteLine($"\n{firstNumber} * {secondNumber} = " + result);
                                            break;
                                        case "/":
                                            if (secondNumber != 0)//Handles erroneous calculations.
                                            {
                                                result = firstNumber / secondNumber;
                                                Console.WriteLine($"\n{firstNumber} / {secondNumber} = " + result);
                                            }
                                            else
                                                Console.WriteLine("\nCannot divide by zero.");
                                            break;
                                    }
                                    Console.Write("\nDo you want to perform another calculation? (y/n): ");//Asks user to keep asking for input.
                                    string another = Console.ReadLine().ToLower();

                                    if (another == "y")//Goes back to asking for a number to the user.
                                    {
                                        break;
                                    }
                                    else if (another == "n")//Exits the program.
                                    {
                                        Console.WriteLine("Exiting the program...");
                                        return;
                                    }
                                    else//Handles invalid inputs.
                                    {
                                        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                                    }
                                }
                                else//Handles invalid inputs.
                                {
                                    Console.WriteLine("Invalid input. Please enter a number.");
                                }
                            }
                            break;
                        }
                        else//Handles invalid inputs.
                        {
                            Console.WriteLine("Invalid input. Please enter +, -, * or / only.");
                        }
                    }
                }
                else//Handles invalid inputs.
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}