using System;
using System.Collections.Generic;

//*** Abstraction :3 ***
abstract class Invalid_0 {
    //Method
    virtual public void ErrorMesssage() {
        Console.WriteLine("Invalid because of something");
    }

}

//*** Inheritance :3 ***
//*** Polymorphism :3 ***
class Invalid_1 : Invalid_0 
{
    override public void ErrorMesssage() 
    {
        Console.WriteLine("Invalid! You must enter a valid number");
    }
}

class Invalid_2 : Invalid_0 
{
    override public void ErrorMesssage() 
    {
        Console.WriteLine("Invalid! You cannot divide by 0. Enter a non-zero number");
    }
}

class Invalid_3 : Invalid_0 
{
    override public void ErrorMesssage() 
    {
        Console.WriteLine("Invalid! first operation must not be =");
    }
}

class Invalid_4 : Invalid_0 
{
    override public void ErrorMesssage() 
    {
        Console.WriteLine("Invalid! You must enter +, -, *, /, or =");
    }
}

class Invalid_5 : Invalid_0 
{
    override public void ErrorMesssage() 
    {
        Console.WriteLine("Invalid! You must enter 'Yes' or 'No'\n");
    }
}

class Calculator
{
    static void Main(string[] args) {

        Invalid_0 IE1 = new Invalid_1();
        Invalid_0 IE2 = new Invalid_2();
        Invalid_0 IE3 = new Invalid_3();
        Invalid_0 IE4 = new Invalid_4();
        Invalid_0 IE5 = new Invalid_5();
        
    {
        // Starting Loop
        while (true) 
        {
            List<double> Numbers = new List<double>();
            List<char> Operations = new List<char>();

            bool hasPerformedCalculation = false;

            while (true)
            {
                // Input Number
                while (true)
                {
                    Console.Write("\nEnter a number      : ");
                    string input = Console.ReadLine();
                    

                    if (input == "=" && Numbers.Count >= 1 && Numbers.Count == Operations.Count)
                    {
                        break;
                    }

                    double num;
                    if (double.TryParse(input, out num))
                    {
                        if (num == 0 && Operations.Count > 0 && Operations[Operations.Count - 1] == '/')
                        {
                            IE2.ErrorMesssage();
                            continue;
                        }
                        numbers.Add(num);
                        break;
                    }
                    else if (input == "=" && hasPerformedCalculation)
                    {
                        break;
                    }
                    else if (input == "=" && Numbers.Count >= 1 && Numbers.Count != Operations.Count)
                    {
                        IE1.ErrorMesssage();
                    }
                    else if (input == "=")
                    {
                        IE1.ErrorMesssage();
                    }
                    else
                    {
                        IE1.ErrorMesssage();
                    }
                }

                // Equals
                if (Numbers.Count >= 1 && Numbers.Count == Operations.Count && Operations.Contains('='))
                {
                    break;
                }

                // Input Operation
                while (true)
                {
                    Console.Write("\nEnter an operation  : ");
                    string input = Console.ReadLine();
     

                    if (input.Length == 1 && "+-*/=".Contains(input))
                    {
                        if (input == "=" && Numbers.Count == 0) // '=' is not allowed as the first operation
                        {
                            IE1.ErrorMesssage();
                        }
                        else if (input == "=" && Operations.Count == 0)
                        {
                            IE3.ErrorMesssage();
                            continue;
                        }
                        else
                        {
                            Operations.Add(input[0]);
                        }
                        break;
                    }
                    else
                    {
                        IE4.ErrorMesssage();
                    }
                }

                // Calculations
                double result = Numbers[0];
                if (Numbers.Count >= 2 && Numbers.Count == Operations.Count && Operations.Contains('='))
                {
                    
                    for (int i = 0; i < Operations.Count; i++)
                    {
                        if (Operations[i] == '/' && Numbers[i + 1] == 0)
                        {
                            IE2.error_messsage();
                            hasPerformedCalculation = false;
                            break;
                        }

                        switch (Operations[i])
                        {
                            case '+':
                                result += Numbers[i + 1];
                                break;
                            case '-':
                                result -= Numbers[i + 1];
                                break;
                            case '*':
                                result *= Numbers[i + 1];
                                break;
                            case '/':
                                result /= Numbers[i + 1];
                                break;
                        }
                    }
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"Result              : {result}");
                    hasPerformedCalculation = true;

                    // Clear Index Values
                    Numbers.Clear();
                    Operations.Clear();

                    // Try Again
                    while (true)
                    {
                        Console.Write("\n\n\nDo you want to try again? (Yes/No): ");
                        string choice = Console.ReadLine();

                        // Start again
                        if (choice.ToLower() == "yes")
                        {
                            Console.WriteLine("\n\n\n");
                            break;
                        }

                        // Terminate
                        else if (choice.ToLower() == "no")
                        {
                            Console.WriteLine("\nCalculator Terminated!");
                            Environment.Exit(0);
                        }

                        // Ask
                        else
                        {
                            IE5.ErrorMesssage();
                        }
                    }
                }
            }
        }
    }
    }
}
