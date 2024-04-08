//Hambiol,Regine Mae G.
//BSIT 2-2

using System;

namespace Calculator
{
   // Class representing a calculator with basic arithmetic operations
    class Calculator
    {
         // Encapsulation: The 'result' field is declared as private to restrict direct access from outside the class
        private double result;

         // Abstraction: This method calculates the result based on the given numbers and operator
        protected double Calculate(double num1, double num2, double result, char op)
        {    //Polymorphism related to the operation
            switch (op)
            {
                case '+':
                    return result + num1;
                case '-':
                    return result - num1;
                case '*':
                    return result * num1;
                case '/':
                    if (num1 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero. Please enter a number or operator");
                        return result;
                    }
                    return result / num1;
                default:
                    return result;
            }
        }

        //abtraction related to the valid operation used
        protected bool IsOperator(string input)
        {
            return input == "+" || input == "-" || input == "*" || input == "/";
        }

        // abstraction of the calculator main function, and user display
        public void PerformCalculation()
        {
            string userInput = "";

            Console.WriteLine("-----------------------");
            Console.WriteLine(" Calculator Activity");
            Console.WriteLine("-----------------------");
        // encapsulation related to the user prompt display using do-while statement
            do
            {
                Console.Write("Enter number or operator (Enter '=' to see the result): ");
                string input = Console.ReadLine();

                if (input == "=")
                {
                    break;
                }
                // encapsulation convert string to double and check its validation
                if (double.TryParse(input, out double number))
                {
                    if (userInput == "")
                        result = number;
                    else
                    {
                        if (!IsOperator(userInput))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid operator.");
                            continue;
                        } // abstraction, update the number and operator used
                        result = Calculate(number, result, result, userInput[0]);
                    }
                }
                else if (IsOperator(input))
                {
                    userInput = input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or operator.");
                    continue;
                }

            } while (true);

            PrintResult();
        }

        // Public method to print the result
        public void PrintResult()
        {
            Console.WriteLine($"Result: {result}");
        }
    }
// main entry point prompt
    class Program
    {
        static void Main(string[] args)
        {
            do
            { //polymorphism, create New instance //abstraction,calling the method used to start the program
                Calculator calculator = new Calculator();
                calculator.PerformCalculation();

                Console.Write("Do you want to continue? (YES/NO): ");
                string continueInput = Console.ReadLine();
//encapsulation, determine either yes or no
                if (continueInput.ToUpper() != "YES")
                    break;

            } while (true);

            Console.WriteLine("Thank you for using the calculator!!!");
            Console.ReadKey();
        }
    }
}
