using System;

namespace CalculatorApp
{
    // Abstract class for binary operations
    abstract class BinaryOperation
    {
        public abstract float Calculate(float num1, float num2);
    }

    // Concrete operation classes
    class Addition : BinaryOperation
    {
        public override float Calculate(float num1, float num2) => num1 + num2;
    }

    class Subtraction : BinaryOperation
    {
        public override float Calculate(float num1, float num2) => num1 - num2;
    }

    class Multiplication : BinaryOperation
    {
        public override float Calculate(float num1, float num2) => num1 * num2;
    }

    class Division : BinaryOperation
    {
        public override float Calculate(float num1, float num2) => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Error: Division by zero!");
    }

    class Calculator
    {
        private string[] inputs = new string[10];
        private int count = 0;

        public void PerformCalculation()
        {
            count = 0;
            bool expectNumber = true;

            while (true)
            {
                Console.WriteLine(expectNumber ? "Enter a number:" : "Enter an operator (+, -, *, /), For the result enter Equal sign (=): ");

                string input = Console.ReadLine();
                if (input == "=") break;

                bool isValidInput = expectNumber ? float.TryParse(input, out _) : "+-*/".Contains(input);
                if (isValidInput)
                {
                    inputs[count++] = input;
                    expectNumber = !expectNumber;
                }
                else Console.WriteLine("Invalid input.");
            }

            if (count > 0) Console.WriteLine("Result: " + CalculateResult());
        }

        private float CalculateResult()
        {
            float result = float.Parse(inputs[0]);

            for (int i = 1; i < count; i += 2)
            {
                string op = inputs[i];
                float num = float.Parse(inputs[i + 1]);
                result = PerformOperation(op, result, num);
            }

            return result;
        }

        private float PerformOperation(string op, float num1, float num2)
        {
            BinaryOperation operation;

            switch (op)
            {
                case "+": operation = new Addition(); break;
                case "-": operation = new Subtraction(); break;
                case "*": operation = new Multiplication(); break;
                case "/": operation = new Division(); break;
                default: throw new InvalidOperationException("Invalid operator: " + op);
            }

            return operation.Calculate(num1, num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            char choice;

            do
            {
                calculator.PerformCalculation();
                Console.WriteLine("Do you want to perform another calculation? (Y/N)");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (char.ToUpper(choice) == 'Y');
        }
    }
}
