using System;
using System.Collections.Generic;
using System.Linq;

// ACTIVITY 2: REVISED CALCULATOR FOR LOOPING AND ALLOWING SEVERAL VALUES UNTIL = IS ENTERED

// ABSTRACTION: here po, i applied the concept of abstraction by creating an abstract class called Calculator bali po, nagdedefine ito sa method na Calculate without specifying pano ito nagiimplement
// INHERITANCE: and then created four classes that inherit from the Calculator class (INHERITANCE)
// POLYMORPHISM: i created a method called Calculate in the Calculator class and then overrode it in the four classes (POLYMORPHISM)
// ENCAPSULATION: para naman po sa encapsulation, i used the access modifier private to hide the implementation details of the classes and only expose the Calculate method. for instance po, the AddCalculator class only has the Calculate method and the rest of the methods are hidden from the user.
public abstract class Calculator
{
    public abstract double Calculate(double[] numbers);
}

public class AddCalculator : Calculator
{
    public override double Calculate(double[] numbers)
    {
        return numbers.Sum();
    }
}

public class SubtractCalculator : Calculator
{
    public override double Calculate(double[] numbers)
    {
        double result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result -= numbers[i];
        }
        return result;
    }
}

public class MultiplyCalculator : Calculator
{
    public override double Calculate(double[] numbers)
    {
        double result = 1;
        foreach (var num in numbers)
        {
            result *= num;
        }
        return result;
    }
}

public class DivideCalculator : Calculator
{
    public override double Calculate(double[] numbers)
    {
        double result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN;
            }
            result /= numbers[i];
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        DisplayHeader();

        while (true)
        {
            List<double> numbers = new List<double>();
            List<string> operators = new List<string>();

            string input;
            do
            {
                input = Console.ReadLine();

                if (double.TryParse(input, out double number))
                {
                    numbers.Add(number);
                }
                else if (IsOperator(input))
                {
                    operators.Add(input);
                }
                else if (input != "=")
                {
                    Console.WriteLine("Invalid input.");
                }
            } while (input != "=");

            if (IsValidInput(numbers, operators))
            {
                double result = PerformCalculation(numbers, operators);
                Console.WriteLine($"The result is: {result}");
            }

            if (!ContinueProgram())
            {
                break;
            }
        }
    }

    static void DisplayHeader()
    {
        Console.WriteLine("".PadLeft(42, '='));
        Console.WriteLine("||".PadRight(40) + "||");
        Console.WriteLine("||".PadRight(13) + "Migo's Calculator" + "".PadRight(10) + "||");
        Console.WriteLine("||".PadRight(40) + "||");
        Console.WriteLine("".PadLeft(42, '='));
    }

    static bool IsOperator(string input)
    {
        return input == "+" || input == "-" || input == "*" || input == "/";
    }

    static bool IsValidInput(List<double> numbers, List<string> operators)
    {
        return numbers.Count >= 2 && operators.Count + 1 == numbers.Count;
    }

    static double PerformCalculation(List<double> numbers, List<string> operators)
    {
        double result = numbers[0];
        for (int i = 0; i < operators.Count; i++)
        {
            Calculator calculator = GetCalculator(operators[i]);
            result = calculator.Calculate(new double[] { result, numbers[i + 1] });
        }
        return result;
    }

    static bool ContinueProgram()
    {
        Console.WriteLine();
        Console.Write("Do you want to perform another calculation from the start? (y/n): ");
        string continueProgram = Console.ReadLine();
        return continueProgram.ToLower() == "y";
    }

    static Calculator GetCalculator(string operatorSymbol)
    {
        switch (operatorSymbol)
        {
            case "+":
                return new AddCalculator();
            case "-":
                return new SubtractCalculator();
            case "*":
                return new MultiplyCalculator();
            case "/":
                return new DivideCalculator();
            default:
                throw new ArgumentException("Invalid operator: " + operatorSymbol);
        }
    }
}
