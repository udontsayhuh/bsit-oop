using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //Super class
    abstract class Calculator
    {
        //Attributes
        public double Result;
        public double Val;

        //Constructor
        public Calculator(double result, double val)
        {
            Result = result;
            Val = val;
        }

        //Method
        public abstract double Compute(double result, double val);
    }

    //Derived Class
    class Addition : Calculator
    {
        public Addition(double result, double val) : base(result, val) { }
        public override double Compute(double result, double val)
        {
            return result + val; //Addition method
        }
    }

    //Derived Class
    class Subtraction : Calculator
    {
        public Subtraction(double result, double val) : base(result, val) { }
        public override double Compute(double result, double val)
        {
            return result - val; //Subtraction method
        }
    }

    // Derived Class
    class Multiplication : Calculator
    {
        public Multiplication(double result, double val) : base(result, val) { }
        public override double Compute(double result, double val)
        {
            return result * val; //Multiplication method
        }
    }

    //Derived Class
    class Division : Calculator
    {
        public Division(double result, double val) : base(result, val) { }
        public override double Compute(double result, double val)
        {
            return result / val; //Division method
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================");
            Console.WriteLine("                       CALCULATOR");
            Console.WriteLine("===========================================================");

            bool computing = true;
            while (computing)  // Creating list to store the values and operation
            {
                List<string> elements = new List<string>();

                bool calculationInProgress = true;
                while (calculationInProgress)
                {
                    bool validInput = true;
                    while (validInput) // Prompts the user to input a value
                    {
                        Console.Write("Enter a value: ");
                        string valueInput = Console.ReadLine();

                        int value;
                        if (int.TryParse(valueInput, out value))  //Check if the user input is valid
                        {
                            elements.Add(value.ToString()); // add the value to the list
                            validInput = false; // initialize to false to break the loop
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer value.");
                        }
                    }
                    if (elements.Count > 0) // To ensure that value is entered first before asking for operator
                    {
                        validInput = true;
                        while (validInput) // Once a value is added, program will ask for an operator
                        {
                            Console.Write("Enter an operator (+, -, *, /) or '=' to calculate: ");
                            string operatorInput = Console.ReadLine();

                            if (operatorInput == "+" || operatorInput == "-" || operatorInput == "*" || operatorInput == "/")  //evaluate if user entered a valid symbol
                            {
                                elements.Add(operatorInput); // add the valid operator to the list
                                validInput = false;
                            }
                            else if (operatorInput == "=")  // program will display the result if the user entered '='
                            {
                                try
                                {
                                    int result = Calculate(elements); // call the 'Calculate' method to display the result
                                    Console.WriteLine("Result: " + result);
                                    while (true)  // ask the user if they want to enter another calculation
                                    {
                                        Console.Write("\nDo you want to perform another calculation? (Y/N): ");
                                        char choice = char.ToUpper(Console.ReadKey().KeyChar);
                                        Console.WriteLine();
                                        if (choice == 'N')
                                        {
                                            computing = false;  // breaks the loop, no creation of list will happen and exit the program
                                            break;
                                        }
                                        else if (choice == 'Y')
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nEnter a valid choice.");
                                        }
                                    }
                                }
                                catch (Exception ex)  // Notify user for their errors
                                {
                                    Console.WriteLine($"{ex.Message}");
                                }
                                finally
                                {
                                    calculationInProgress = false;  // program will not prompt the user to enter value or operator anymore
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid symbol for operator. Please enter a valid operator or '=' to calculate.");
                            }
                        }
                    }
                }
            }
            Console.WriteLine("\nThank you for using the Calculator. Adios mi amigo, mi amiga! mwamwa <3");
        }

        //Method to calculate expression in the list
        static int Calculate(List<string> elements)
        {
            if (elements.Count % 2 == 0) // Evaluate if the list creates a complete expression
            {
                throw new InvalidOperationException("Invalid expression. Operator missing.");
            }

            int result = int.Parse(elements[0]); // intialize that the result is the first value in the list

            for (int i = 1; i < elements.Count; i += 2)
            {
                string op = elements[i];
                int val = int.Parse(elements[i + 1]);

                switch (op)
                {
                    case "+":
                        result = result + val;
                        break;
                    case "-":
                        result = result - val;
                        break;
                    case "*":
                        result = result * val;
                        break;
                    case "/":
                        if (val == 0)
                            throw new DivideByZeroException("Values cannot be divided by 0.");
                        result = result / val;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operator.");
                }
            }

            return result;
        }
    }
}
