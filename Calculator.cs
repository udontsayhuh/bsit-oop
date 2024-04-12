using System;

namespace MyCalculator
{
    class Calculator
    {
        public void RunCalculator()
        {
            string value = "Y"; // initializing the value with Y 
            do
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

                    if (input == "=")
                    {
                        if (!firstInput)
                        {
                            result = CalculateResult(result, temp, lastOperation);
                            Console.WriteLine($"Result: {result}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("INVALID INPUT! PLEASE ENTER A VALID EXPRESSION.");
                            continue;
                        }
                    }

                    if (float.TryParse(input, out float num))
                    {
                        if (lastOperation == '/')
                        {
                            if (num == 0)
                            {
                                Console.WriteLine("CANNOT DIVIDE BY ZERO. PLEASE ENTER A VALID NUMBER.");
                                continue;
                            }
                            else
                            {
                                temp = num;
                            }
                        }
                        else if (firstInput)
                        {
                            result = num;
                            firstInput = false;
                        }
                        else
                        {
                            temp = num;
                        }
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT! MUST BE A NUMERICAL VALUE.");
                        continue;
                    }

                    while (true)
                    {
                        Console.Write("Enter an operator (+, -, *, /) or (=) to calculate: ");
                        input = Console.ReadLine();

                        if (input == "=")
                        {
                            result = CalculateResult(result, temp, lastOperation);
                            Console.WriteLine($"Result: {result}");

                            Console.Write("\nDo you want to do another calculation again? (y/n): ");
                            value = Console.ReadLine().ToUpper();

                            if (value == "N")
                            {
                                Console.WriteLine("\n-------------------------------------");
                                Console.WriteLine("   BYE T-T EXITING THE CALCULATOR ...");
                                Console.WriteLine("-------------------------------------");
                                return;
                            }
                            else if (value != "Y")
                            {
                                Console.WriteLine("INVALID INPUT! PLEASE ENTER 'Y' OR 'N'.");
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (IsOperationSymbol(input))
                        {
                            lastOperation = input[0];
                            break;
                        }
                        else
                        {
                            Console.WriteLine("INVALID INPUT! MUST BE AN OPERATION SYMBOL OR =.");
                        }
                    }
                    Console.Clear(); 
                }
            }
            while (value == "Y");
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
                    if (temp == 0)
                    {
                        Console.WriteLine("CANNOT DIVIDE BY ZERO. PLEASE ENTER A VALID NUMBER.");
                        return result;
                    }
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
        }
    }
}
