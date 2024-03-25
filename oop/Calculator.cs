using System;

// here po, i applied the concept of abstraction by creating an abstract class called Calculator (ABSTRACTION)
// bali po, nagdedefine ito sa method na Calculate without specifying pano ito nagiimplement
// and then created four classes that inherit from the Calculator class (INHERITANCE)
// for polymorphism naman po, i created a method called Calculate in the Calculator class and then overrode it in the four classes (POLYMORPHISM)


// abstraction
public abstract class Calculator
{
    public abstract double Calculate(double num1, double num2);
}
public class AddCalculator : Calculator
{
    public override double Calculate(double num1, double num2) 
    {
        return num1 + num2;
    }
}

public class SubtractCalculator : Calculator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}

public class MultiplyCalculator : Calculator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 * num2;
    }
}

public class DivideCalculator : Calculator
{
    public override double Calculate(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN; // NaN means "Not a Number" po
        }
        return num1 / num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("".PadLeft(42, '='));
        Console.WriteLine("||".PadRight(40) + "||");
        Console.WriteLine("||".PadRight(13) + "Migo's Calculator" + "".PadRight(10) + "||");
        Console.WriteLine("||".PadRight(40) + "||");
        Console.WriteLine("".PadLeft(42, '='));
        Console.WriteLine();

        while (true)
        {
            

            // prompt the user to enter the first number.
            double num1;
            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                break; // terminate the program if the input is invalid
            }

            // Loop indefinitely until the user chooses to exit.
            while (true)
            {
                // prompt the user to choose the operation to use.
                Console.WriteLine();
                Console.WriteLine("Choose the operation to use  | + | - | * | / | : ");
                string operation = Console.ReadLine();

                // create a calculator object based on the user's input.
                Calculator calculator = null;
                switch (operation)
                {
                    case "+":
                        calculator = new AddCalculator();
                        break;
                    case "-":
                        calculator = new SubtractCalculator();
                        break;
                    case "*":
                        calculator = new MultiplyCalculator();
                        break;
                    case "/":
                        calculator = new DivideCalculator();
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please use +, -, *, or /.");
                        continue;
                }

                // prompt the user to enter second number.
                Console.Write("Enter the second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                // calculate the result and display it.
                double result = calculator.Calculate(num1, num2);
                if (double.IsNaN(result))
                {
                    continue;
                }
                Console.WriteLine($"The result is: {result}");

                // ask the user if they want to do another calculation again.
                Console.WriteLine();
                Console.Write("Do you want to do another calculation again? (y/n): ");
                string continueCalculation = Console.ReadLine();
                if (continueCalculation.ToLower() != "y")
                {
                    break;
                }

                // prompt the user to enter the first number again if they want to continue.
                Console.Write("Enter the first number: ");
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    break; // terminate the program if the input is invalid
                }
            }

            // asking user to do another calculation. If yes, repeat the process. If no, exit the program.
            Console.WriteLine();
            Console.Write("Do you want to perform another calculation from the start? (y/n): ");
            string continueProgram = Console.ReadLine();
            if (continueProgram.ToLower() != "y")
            {
                break;
            }
        }
    }
}
