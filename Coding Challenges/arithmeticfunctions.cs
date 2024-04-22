/*Write a C# program that can perform basic arithmetic functions. 
(Addition, Subtraction, Multiplication, and Division). The user must be allowed to select which arithmetic function he/she wants to use, 
and then they will be prompted to enter only two numbers after selecting the arithmetic function. Print the result afterwards, 
and then after printing ask the user if he/she wants toperform another action or not. 
If yes, repeat the program, if not terminate the program.*/

using System;

//abstraction
//abstract base class that represents a calculator with a calculate method
abstract class Calculator   
{
    //encapsulation
    public abstract double Calculate(double num1, double num2);
}

//Addition subclass inheriting from Calculator (inheritance)
//addition operation
class Addition : Calculator
{
    //method to perform addition
    public override double Calculate(double num1, double num2)
    {
        return num1 + num2;
    }
}

//Subtraction subclass inheriting from Calculator (inheritance)
//Subtraction operation
class Subtraction : Calculator
{
    //method to perform subtraction
    public override double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}

//Multiplication subclass inheriting from Calculator (inheritance)
//Multiplication operation
class Multiplication : Calculator
{
    //method to perform multiplication
    public override double Calculate(double num1, double num2)
    {
        return num1 * num2;
    }
}

//Division subclass inheriting from Calculator (inheritance)
//Division operation
class Division : Calculator
{
    //method to perform division
    public override double Calculate(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return num1 / num2;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("WELCOME TO BASIC ARITHMETIC FUNCTIONS");
        Console.WriteLine("--------------------------------------");
        bool repeat = true;

        while (repeat)
        {
            //user prompt to select an arithmetic operation
            Console.WriteLine("Select an arithmetic operation:");
            Console.WriteLine("a. Addition (+)");
            Console.WriteLine("b. Subtraction (-)");
            Console.WriteLine("c. Multiplication (*)");
            Console.WriteLine("d. Division (/)");

            //user input for the arithmetic operation
            Console.Write("\nEnter your choice (a-b): ");
            string choiceInput = Console.ReadLine();

            char choice;
            if (!char.TryParse(choiceInput, out choice) || choice < 'a' || choice > 'd')
            {
                Console.WriteLine("Invalid choice! Please select a valid arithmetic operation."); //invalid message if user input other 
                continue;
            }

            double num1, num2;
            bool validInput = false;

            //user input for the first number 
            do
            {
                Console.Write("\nEnter the first number: ");
                string num1Input = Console.ReadLine();
                if (!double.TryParse(num1Input, out num1))
                {
                    Console.WriteLine("Invalid! Please enter a valid number."); //invalid message if user enter invalid value
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);

            validInput = false;

            //user input for the second number 
            do
            {
                Console.Write("Enter the second number: ");
                string num2Input = Console.ReadLine();
                if (!double.TryParse(num2Input, out num2))
                {
                    Console.WriteLine("Invalid! Please enter a valid number."); //invalid message if user enter invalid value
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);

            Calculator calculator;

            //selection of the calculator operation based on the user choice
            switch (choice)
            {
                case 'a':
                    calculator = new Addition();
                    break;
                case 'b':
                    calculator = new Subtraction();
                    break;
                case 'c':
                    calculator = new Multiplication();
                    break;
                case 'd':
                    calculator = new Division();
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please select a valid arithmetic operation."); //invalid message if user input other
                    continue;
            }

            try
            {
                //calculation and result display
                double result = calculator.Calculate(num1, num2);
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //exception message display
            }

            //prompt if user want to perform another action
            Console.Write("\nDo you want to perform another action? (Y/N): ");
            string answer = Console.ReadLine();

            repeat = (answer.ToLower() == "y");  //checks if user wants to repeat the program
        }
    }
}
