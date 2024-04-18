// Miyuki Mharie C. Parocha
// BSIT 2-2

using System;
abstract class Calculation
{
    public abstract double Add(double num1, double num2);
    public abstract double Subtract(double num1, double num2);
    public abstract double Multiply(double num1, double num2);
    public abstract double Divide(double num1, double num2);
}
class Calculator : Calculation // Inherits the abstract class Calculation
{
    private double result; // Store the result of the computation, can only be access through setters and getters

    public void setResult(double result) // Store result
    {
        this.result = result;
    }
    public double getResult() // Display result
    {
        return result;
    }
    public override double Add(double num1, double num2) // Overriding method from different class
    {
        return num1 + num2;
    }
    public override double Subtract(double num1, double num2) // Overriding method from different class
    {
        return num1 - num2;
    }
    public override double Multiply(double num1, double num2) // Overriding method from different class
    {
        return num1 * num2;
    }
    public override double Divide(double num1, double num2) // Overriding method from different class
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero."); // If the user inputs 0
            return double.NaN;
        }
        return num1 / num2;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow; // Change the text color to Yellow
        Console.WriteLine("\n*************************************************************************");
        Console.BackgroundColor = ConsoleColor.DarkYellow; // Change the text background color to Dark Yellow
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("                                 CALCULATOR                              ");
        Console.ResetColor(); // Reset the foreground color and background color
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("*************************************************************************");
        Console.ResetColor(); // Reset the text background color

        Calculator calculation = new Calculator(); // Creating a calculation object
        double num, result;
        string choice;
        string operation = "", input = "";
        bool isExit = false;

        while (!isExit) // Continue the loop while isExit varaible is not true
        {
            result = 0; // Reset result for each calculation

            while (true) // Continue the loop unless changed to false or a (break) is called
            {
                if (input == "=") // If <input> varible is equals to =, display result
                {
                    calculation.setResult(result); // Store result to the object class
                    Console.Write("\n\tThe answer is: ");
                    Console.ForegroundColor = ConsoleColor.Green; // Change the text color
                    Console.Write(calculation.getResult()); // Call the result from the object class
                    Console.ResetColor(); // Reset the text color
                    break;
                }

                Console.Write("\nEnter number: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (!double.TryParse(Console.ReadLine(), out num)) // Continue the loop if user input  a non-double varible element
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Change the text color
                    Console.Write("Please enter a valid number.\n");
                    Console.ResetColor(); // Reset the text color
                    continue; // Continue to loop
                }
                Console.ResetColor();

                switch (operation)
                {
                    case "+":
                        result = calculation.Add(result, num); // Call add method from the object
                        break;
                    case "-":
                        result = calculation.Subtract(result, num); // Call subtract method from the object
                        break;
                    case "*":
                        result = calculation.Multiply(result, num); // Call multiply method from the object
                        break;
                    case "/":
                        result = calculation.Divide(result, num); // Call divide method from the object
                        break;
                    default:
                        result = num; // If no operation yet, start with the first number
                        break;
                }

                operation = ""; // Reset the value of <operation> variable

                while (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "=") // continue to loop while the condition is not meet
                {
                    Console.Write("Enter operation (+, -, *, /) or '=' to calculate: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    operation = Console.ReadLine();
                    Console.ResetColor(); // Reset the text color

                    if (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "=")
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Change the text color
                        Console.Write("Invalid operation. ");
                        Console.ResetColor(); // Reset the text color

                    }
                }

                if (operation == "=")
                {
                    input = operation; // Store the value of <operation> to the <input> to be use in the next iteration of the loop
                }
            }

            Console.Write("\n\nType Y to try again, press any other key to exit: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            choice = Console.ReadLine();
            Console.ResetColor(); // Reset the text color

            if (choice.ToUpper() != "Y")
            {
                isExit = true;
            }
            else
            {
                operation = ""; // Reset <operation> for the next computation
                input = ""; // Reset <input> for the next computation
            }
        }
    }
}
