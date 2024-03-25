using System;

class Calculator
{
    private string repeat; // Encapsulation: The repeat variable is encapsulated as private to the Calculator class.
    private double double_result; // Encapsulation: The double_result variable is encapsulated as private to the Calculator class.

    public void Calculate()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("(Enter a number)\n");
            if (!double.TryParse(Console.ReadLine(), out double double_num1))
            {
                Console.WriteLine("\nThe program will terminate due to non-numeric input.");
                break;
            }

            Console.Clear();
            Console.WriteLine("(Enter an operator (+ - * /))\n");
            Console.Write($"{double_num1} ");
            if (!char.TryParse(Console.ReadLine(), out char char_operator) || !(char_operator == '+' || char_operator == '-' || char_operator == '*' || char_operator == '/'))
            {
                Console.WriteLine("\nThe program will terminate due to invalid operator input.");
                break;
            }

            Console.Clear();
            Console.WriteLine("(Enter another number)\n");
            Console.Write($"{double_num1} {char_operator} ");
            if (!double.TryParse(Console.ReadLine(), out double double_num2))
            {
                Console.WriteLine("\nThe program will terminate due to non-numeric input.");
                break;
            }

            Console.Clear();
            Console.WriteLine("\n");

            // Abstraction: The arithmetic operations are abstracted within the switch-case statement.
            switch (char_operator)
            {
                case '+':
                    double_result = double_num1 + double_num2;
                    break;

                case '-':
                    double_result = double_num1 - double_num2;  
                    break;

                case '*':
                    double_result = double_num1 * double_num2;
                    break;

                case '/':
                    if (double_num2 == 0)
                    {
                        Console.WriteLine($"{double_num1} {char_operator} {double_num2} = Undefined/Infinity");
                        break;
                    }

                    double_result = double_num1 / double_num2;
                    break;
            }

            // Polymorphism: The behavior of calculating and displaying results varies based on the operator used.
            if (!(double_num2 == 0) || !(char_operator == '/'))
            {
                Console.WriteLine($"{double_num1} {char_operator} {double_num2} = {double_result:n}");
            }

            while (true)
            {
                Console.Write("\n\nDo you want to continue? (Y/N): ");
                repeat = Console.ReadLine().ToUpper();

                if (repeat == "N")
                {
                    Console.WriteLine("Program has terminated.");
                    return;
                }
                else if (repeat == "Y")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter Y or N.");
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.Calculate();
    }
}
