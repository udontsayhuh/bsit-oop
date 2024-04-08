using System;
using System.Collections.Generic;

//*** Abstraction :3 ***
abstract class invalid_0 {
    //Method
    virtual public void error_messsage() {
        Console.WriteLine("Invalid because of something");
    }

}

//*** Inheritance :3 ***
//*** Polymorphism :3 ***
class invalid_1 : invalid_0 
{
    override public void error_messsage() 
    {
        Console.WriteLine("Invalid! You must enter a valid number");
    }
}

class invalid_2 : invalid_0 
{
    override public void error_messsage() 
    {
        Console.WriteLine("Invalid! You cannot divide by 0. Enter a non-zero number");
    }
}

class invalid_3 : invalid_0 
{
    override public void error_messsage() 
    {
        Console.WriteLine("Invalid! first operation must not be =");
    }
}

class invalid_4 : invalid_0 
{
    override public void error_messsage() 
    {
        Console.WriteLine("Invalid! You must enter +, -, *, /, or =");
    }
}

class invalid_5 : invalid_0 
{
    override public void error_messsage() 
    {
        Console.WriteLine("Invalid! You must enter 'Yes' or 'No'\n");
    }
}

class Calculator
{
    static void Main(string[] args) {

        invalid_0 IE1 = new invalid_1();
        invalid_0 IE2 = new invalid_2();
        invalid_0 IE3 = new invalid_3();
        invalid_0 IE4 = new invalid_4();
        invalid_0 IE5 = new invalid_5();
        
    {
        // Starting Loop
        while (true) 
        {
            List<double> numbers = new List<double>();
            List<char> operations = new List<char>();

            bool hasPerformedCalculation = false;

            while (true)
            {
                // Input Number
                while (true)
                {
                    Console.Write("\nEnter a number      : ");
                    string input = Console.ReadLine();
                    

                    if (input == "=" && numbers.Count >= 1 && numbers.Count == operations.Count)
                    {
                        break;
                    }

                    double num;
                    if (double.TryParse(input, out num))
                    {
                        if (num == 0 && operations.Count > 0 && operations[operations.Count - 1] == '/')
                        {
                            IE2.error_messsage();
                            continue;
                        }
                        numbers.Add(num);
                        break;
                    }
                    else if (input == "=" && hasPerformedCalculation)
                    {
                        break;
                    }
                    else if (input == "=" && numbers.Count >= 1 && numbers.Count != operations.Count)
                    {
                        IE1.error_messsage();
                    }
                    else if (input == "=")
                    {
                        IE1.error_messsage();
                    }
                    else
                    {
                        IE1.error_messsage();
                    }
                }

                // Equals
                if (numbers.Count >= 1 && numbers.Count == operations.Count && operations.Contains('='))
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
                        if (input == "=" && numbers.Count == 0) // '=' is not allowed as the first operation
                        {
                            IE1.error_messsage();
                        }
                        else if (input == "=" && operations.Count == 0)
                        {
                            IE3.error_messsage();
                            continue;
                        }
                        else
                        {
                            operations.Add(input[0]);
                        }
                        break;
                    }
                    else
                    {
                        IE4.error_messsage();
                    }
                }

                // Calculations
                double result = numbers[0];
                if (numbers.Count >= 2 && numbers.Count == operations.Count && operations.Contains('='))
                {
                    
                    for (int i = 0; i < operations.Count; i++)
                    {
                        if (operations[i] == '/' && numbers[i + 1] == 0)
                        {
                            IE2.error_messsage();
                            hasPerformedCalculation = false;
                            break;
                        }

                        switch (operations[i])
                        {
                            case '+':
                                result += numbers[i + 1];
                                break;
                            case '-':
                                result -= numbers[i + 1];
                                break;
                            case '*':
                                result *= numbers[i + 1];
                                break;
                            case '/':
                                result /= numbers[i + 1];
                                break;
                        }
                    }
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"Result              : {result}");
                    hasPerformedCalculation = true;

                    // Clear Index Values
                    numbers.Clear();
                    operations.Clear();

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
                            IE5.error_messsage();
                        }
                    }
                }
            }
        }
    }
    }
}
