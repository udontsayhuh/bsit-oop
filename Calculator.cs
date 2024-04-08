using Calculator;
using System;

namespace Calculator
{
    //polymorphism
    //INVALID INPUT 
    public class Displayerrormessage    //base class (parent) 
    {
        public virtual void errormessage()
        {
            // Base implementation can be left empty
        }
    }
    public class Invalidoperator : Displayerrormessage
    {
        public override void errormessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: ");
            Console.WriteLine("Please enter a valid input again (Arithmetic operator).");
            Console.ResetColor();
        }
    }

    public class Invalidinteger : Displayerrormessage
    {
        public override void errormessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: ");
            Console.WriteLine("Please enter valid input again (numeric value).");
            Console.ResetColor();
        }
    }

    public class InvalidEqual : Displayerrormessage
    {
        public override void errormessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT: ");
            Console.WriteLine("The equal sign is not applicable in the first entry .");
            Console.ResetColor();
        }
    }

    public class Calculatorf
    {
        //encapsulation 
        private double nextValue;
        private double result;
        private string operation = " ";

        public void GetUserInput()
        {
            bool validUserInput = false;
            while (!validUserInput)
            {
                Console.Write("\nEnter a value: ");
                if (!double.TryParse(Console.ReadLine(), out result))
                {
                    Displayerrormessage myInvalidinteger = new Invalidinteger();
                    myInvalidinteger.errormessage();
                    continue;
                }
                else
                {
                    validUserInput = true;
                }
            }

            while (true)
            {
                Console.Write("\nEnter your arithmetic operator: ");
                string operation = Console.ReadLine();

                if (operation == "=")
                {
                    if (nextValue == 0 && result != 0)  //if the user enter a equal sign in the first entry ofthe arithmetic operator. 
                    {
                        Displayerrormessage myInvalidEqual = new InvalidEqual();
                        myInvalidEqual.errormessage();
                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nThe result is: {result}");
                    Console.ResetColor();
                    break; // Exit the loop when '=' is encountered
                }

                if (operation != "+" && operation != "-" && operation != "*" && operation != "/") // checking if valid ba yung input 
                {
                    Displayerrormessage myInvalidoperator = new Invalidoperator();
                    myInvalidoperator.errormessage();
                    continue;
                }

                validUserInput = false; // Update the existing validInput variable
                while (!validUserInput)
                {
                    Console.Write("\nEnter a value: "); 
                    if (!double.TryParse(Console.ReadLine(), out nextValue))
                    {
                        Displayerrormessage myInvalidinteger = new Invalidinteger();
                        myInvalidinteger.errormessage();
                        continue;
                    }
                    else
                    {
                        validUserInput = true;
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
        public void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+       CALCULATOR PROGRAM       +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.ResetColor();
        }

        public void DisplayArithmeticOperators()
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

        static void Main(string[] args)
        {
            Calculatorf calculator = new Calculatorf();

            do
            {
                calculator.DisplayHeader();
                calculator.DisplayArithmeticOperators();
                calculator.GetUserInput();

                Console.ReadKey(); // to delay the the press 1 

                Console.WriteLine("\n|--------------------------------|");
                Console.WriteLine("|        Press 1 to proceed      |");
                Console.WriteLine("|        Press 2 to exit         |");
                Console.WriteLine("|--------------------------------|");

                Console.Write("Enter your choice: ");  // asking the user to continue or not 
                string repeat = Console.ReadLine();

                if (repeat != "1")
                {
                    break; // Exit the loop if the user doesn't want to proceed
                }
                Console.Clear(); // Clear the console for the next calculation
            }
            while (true);
            Console.ReadLine(); //used to pause the console output and wait for the user to press Enter before the console application is closed.
        }
    }
}

