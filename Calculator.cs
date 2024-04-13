using Calculator;
using System;

namespace Calculator
{
    //polymorphism
    //INVALID INPUT 
    public class DisplayErrorMessage    //base class (parent) 
    {
        public virtual void ErrorMessage()
        {
            // Base implementation can be left empty
        }
    }
    public class InvalidOperator : DisplayErrorMessage
    {
        public override void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: ");
            Console.WriteLine("Please enter a valid input again (Arithmetic operator).");
            Console.ResetColor();
        }
    }

    public class InvalidInteger : DisplayErrorMessage
    {
        public override void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: ");
            Console.WriteLine("Please enter valid input again (numeric value).");
            Console.ResetColor();
        }
    }

    public class InvalidEqual : DisplayErrorMessage
    {
        public override void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: ");
            Console.WriteLine("The equal sign is not applicable in the first entry .");
            Console.ResetColor();
        }
    }

    public class InvalidProceed : DisplayErrorMessage
    {
        public override void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: ");
            Console.WriteLine("Please enter either 1 or 2.");
            Console.ResetColor();
        }
    }


    public class Calcu
    {
        //encapsulation 
        //declaring variables 
        private double nextValue;
        private double result;
        private string operation = string.Empty;

        //Getting the first input of the user 
        public void GetUserInput()
        {
            bool ValidUserInput = false;
            while (!ValidUserInput)
            {
                Console.Write("\nEnter a value: ");
                if (!double.TryParse(Console.ReadLine(), out result))
                {
                    DisplayErrorMessage myInvalidInteger = new InvalidInteger();
                    myInvalidInteger.ErrorMessage();
                    continue;
                }
                else
                {
                    ValidUserInput = true;
                }
            }

            //Getting the operator (+, - , * , / , =)
            while (true)
            {
                Console.Write("\nEnter your arithmetic operator: ");
                string operation = Console.ReadLine();

                if (operation == "=")
                {
                    if (nextValue == 0 && result != 0)  //if the user enter equal sign in the first entry of the arithmetic operator. 
                    {
                        DisplayErrorMessage myInvalidEqual = new InvalidEqual();
                        myInvalidEqual.ErrorMessage();
                        continue;
                    }
                    //if you put equal sign and it has 2 variables, it will print the result. 
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nThe result is: {result}");
                    Console.ResetColor();
                    break; // Exit the loop when '=' is encountered
                }

                if (operation != "+" && operation != "-" && operation != "*" && operation != "/") // checking if valid ba yung input 
                {
                    DisplayErrorMessage myInvalidOperator = new InvalidOperator();
                    myInvalidOperator.ErrorMessage();
                    continue;
                }

                ValidUserInput = false; // Update the existing validInput variable
                while (!ValidUserInput)
                {
                    Console.Write("\nEnter a value: "); //Getting the 2nd variable
                    if (!double.TryParse(Console.ReadLine(), out nextValue))
                    {
                        DisplayErrorMessage myInvalidinteger = new InvalidInteger();
                        myInvalidinteger.ErrorMessage();
                        continue;
                    }
                    else
                    {
                        ValidUserInput = true;
                    }
                }

                switch (operation)
                {
                    case "+":
                        result += nextValue;
                        break;
                    case "-":
                        result -= nextValue;
                        break;
                    case "*":
                        result *= nextValue;
                        break;
                    case "/":
                        if (nextValue != 0 && result != 0)
                        {
                            result /= nextValue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("INVALID INPUT: Division by zero");
                            Console.ResetColor();
                        }
                        break;
                }
            }
        }

        //abstraction: displaying 
        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+       CALCULATOR PROGRAM       +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.ResetColor();
        }

        public static void DisplayArithmeticOperators()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|--------------------------------|");
            Console.WriteLine("|      Arithmetic Operators:     |");
            Console.WriteLine("|________________________________|");
            Console.WriteLine("|            + : ADD             |");
            Console.WriteLine("|            - : MINUS           |");
            Console.WriteLine("|            * : TIMES           |");
            Console.WriteLine("|            / : DIVIDE          |");
            Console.WriteLine("|--------------------------------|");
            Console.WriteLine("|            = : RESULT          |");
            Console.WriteLine("|--------------------------------|");
            Console.ResetColor();
        }

        public static void DisplayingPress1and2()
        {
            Console.ReadKey(); // to delay the the press 1 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n|--------------------------------|");
            Console.WriteLine("|        Press 1 to proceed      |");
            Console.WriteLine("|        Press 2 to exit         |");
            Console.WriteLine("|--------------------------------|");
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            //Creating a new instance
            Calcu calculator = new();
            InvalidProceed myInvalidproceed = new();

            do
            {
                Calcu.DisplayHeader();
                Calcu.DisplayArithmeticOperators();
                calculator.GetUserInput();
                Calcu.DisplayingPress1and2();

                while (true)
                {
                    Console.Write("Enter your choice: ");
                    string repeat = Console.ReadLine();

                    if (repeat != "1" && repeat != "2")
                    {
                        myInvalidproceed.ErrorMessage();
                        continue; // Continue the loop to ask for input again
                    }
                    else if (repeat == "2")
                    {
                        return; // Exit the loop if the user doesn't want to proceed
                    }
                    else
                    {
                        break; // Proceed to the next iteration if the user chooses to continue
                    }
                }
                Console.Clear(); // Clear the console for the next calculation
            } while (true);
        }
    }
}
