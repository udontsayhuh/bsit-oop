using System;

namespace MyCalculator
{
    class Calculator
    {
        public void RunCalculator()
        {
            string response;
            do
            {
                Calculate();

                Console.Write("\nDo you want to perform another calculation again? (Y/N): ");
                response = Console.ReadLine().Trim().ToUpper();
                while (response != "Y" && response != "N")
                {
                    Console.WriteLine("INVALID INPUT! Please enter 'Y' or 'N'.");
                    Console.Write("Do you want to perform another calculation again? (Y/N): ");
                    response = Console.ReadLine().Trim().ToUpper();
                }
            }
            while (response == "Y");
        }

        private void Calculate()
        {
            float result = 0;
            float temp = 0;
            char lastOperation = '+';
            bool firstInput = true;

            Console.Clear();

            while (true)
            {
                Console.Write("\nEnter a number: ");
                string input = Console.ReadLine();

                if (!float.TryParse(input, out float num))
                {
                    Console.WriteLine("INVALID INPUT! Must be a numerical value.");
                    continue;
                }

                if (lastOperation == '/' && num == 0)
                {
                    Console.WriteLine("CANNOT DIVIDE BY ZERO. PLEASE ENTER A VALID NUMBER.");
                    continue;
                }

                if (firstInput)
                {
                    result = num;
                    firstInput = false;
                }
                else
                {
                    temp = num;
                }

                while (true)
                {
                    Console.Write("Enter an operator (+, -, *, /) or (=) to calculate: ");
                    input = Console.ReadLine();

                    if (IsOperationSymbol(input))
                    {
                        lastOperation = input[0];

                        Console.Write("Enter the next number: ");
                        input = Console.ReadLine();

                        if (!float.TryParse(input, out float secondNum))
                        {
                            Console.WriteLine("INVALID INPUT! Must be a numerical value.");
                            continue;
                        }

                        result = CalculateResult(result, secondNum, lastOperation);
                        Console.WriteLine($"Result: {result}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT! Must be an operation symbol or '='.");
                    }
                }
            }
        }

        private bool IsOperationSymbol(string symbol)
        {
            return symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/";
        }

        private float CalculateResult(float result, float temp, char lastOperation)
        {
            switch (lastOperation)
            {
                case '+':
                    result += temp;
                    break;
                case '-':
                    result -= temp;
                    break;
                case '*':
                    result *= temp;
                    break;
                case '/':
                    result /= temp;
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.RunCalculator();

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("   BYE T-T EXITING THE CALCULATOR ...");
            Console.WriteLine("-------------------------------------");
        }
    }
}
