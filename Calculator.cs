using System;
using System.Threading.Tasks;
namespace calculator
{
    public static class Calculator
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                double valueFirst = 0;
                double valueSecond = 0;
                double result = 0;
                string operation = "";

                Console.Clear(); //to clear the screen after the loop 

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+       CALCULATOR PROGRAM       +");
                Console.WriteLine("++++++++++++++++++++++++++++++++++");
                Console.ResetColor();

                Console.Write("Enter the first value: ");
                if (!double.TryParse(Console.ReadLine(), out valueFirst)) // if the user input a letter
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID INPUT: Please enter a valid number.");
                    await Task.Delay(1000);
                    return;
                }

                Console.Write("\nEnter the second value: ");
                if (!double.TryParse(Console.ReadLine(), out valueSecond)) // if the user input a letter
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID INPUT: Please enter a valid number.");
                    await Task.Delay(1000);
                    return;
                }

                while (string.IsNullOrEmpty(operation) || !(operation == "+" || operation == "-" || operation == "*" || operation == "/"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("|--------------------------------|");
                    Console.WriteLine("|      Arithmetic Operator:      |");
                    Console.WriteLine("|________________________________|");
                    Console.WriteLine("|            + : ADD             |");
                    Console.WriteLine("|            - : MINUS           |");
                    Console.WriteLine("|            * : TIMES           |");
                    Console.WriteLine("|            / : DIVIDE          |");
                    Console.WriteLine("|--------------------------------|");
                    Console.ResetColor();

                    Console.Write("Enter your arithmetic operator: ");
                    operation = Console.ReadLine();

                    if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                    {
                        Console.Clear();
                        Console.WriteLine($"Your first value is: {valueFirst}"); 
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("INVALID INPUT: Please enter a valid arithmetic operator.");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("|--------------------------------|");
                        Console.WriteLine("|      Arithmetic Operator:      |");
                        Console.WriteLine("|________________________________|");
                        Console.WriteLine("|            + : ADD             |");
                        Console.WriteLine("|            - : MINUS           |");
                        Console.WriteLine("|            * : TIMES           |");
                        Console.WriteLine("|            / : DIVIDE          |");
                        Console.WriteLine("|--------------------------------|");
                        Console.ResetColor();
                        Console.Write("Enter your arithmetic operator: ");
                        operation = Console.ReadLine();
                    }
                }

                switch (operation)
                {
                    case "+":
                        result = valueFirst + valueSecond;
                        break;
                    case "-":
                        result = valueFirst - valueSecond;
                        break;
                    case "*":
                        result = valueFirst * valueSecond;
                        break;
                    case "/":
                        if (valueSecond == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("INVALID INPUT: Division by zero is not allowed.");
                            Console.ResetColor();
                            Console.Write("Enter your second value: ");
                            string secondval = Console.ReadLine();
                            

                            if (!double.TryParse(secondval, out valueSecond))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("INVALID INPUT: Please enter a valid number.");
                                Console.ResetColor();
                                return;
                            }
                            else
                            {
                                result = valueFirst / valueSecond;
                                break;
                            }
                        }
                        else
                        {
                            result = valueFirst / valueSecond;
                            break;
                        }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The result is: " + result);
                Console.ResetColor();
                Console.ReadKey(); // to delay the the press 1 

                Console.WriteLine("\n|--------------------------------|");
                Console.WriteLine("|        Press 1 to proceed      |");
                Console.WriteLine("|        Press 2 to exit         |");
                Console.WriteLine("|--------------------------------|");

                Console.Write("Enter your choice: ");
                string repeat = Console.ReadLine();

                if (repeat == "2")
                {
                    return; //terminate 
                }

                operation = " ";
                valueFirst = 0;
                valueSecond = 0;
                result = 0;

                Console.ReadLine(); //used to pause the console output and wait for the user to press Enter before the console application is closed.
            }
        }
    }
}