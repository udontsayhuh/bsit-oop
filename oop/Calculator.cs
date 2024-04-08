using System;

//Halili, Ma. Alex P. BSIT 2-2
namespace MyCalculator
{
    class Calculator
    {
        public void RunCalculator()
        {
            string value = "y"; // initializing the value with y 
            do
            {
                List<float> numbers = new List<float>(); // for numbers
                List<string> symbols = new List<string>(); // for symbols

                while (true)
                {
                    Console.Write("Enter a number (enter '=' to calculate): ");
                    string input = Console.ReadLine();

                    if (input == "=")
                        break;
                //converting the input into float and pass it using out
                    if (!float.TryParse(input, out float number))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number or '=' to calculate.");
                        continue;
                    }
                    numbers.Add(number);

                    Console.Write("Enter symbol you want to use (+, -, *, /) or '=' to calculate: ");
                    string symbol = Console.ReadLine();

                    if (symbol == "=")
                        break;

                    if (symbol != "+" && symbol != "-" && symbol != "*" && symbol != "/")
                    {
                        Console.WriteLine("Invalid symbol. Please enter a valid symbol or '=' to calculate.");
                        continue;
                    }
                    symbols.Add(symbol); // adding d symbol in the list
                }

                PerformOperation(numbers, symbols); //calling d method

                Console.WriteLine("Do you want to continue? (Y/N)");
                value = Console.ReadLine().ToLower();
                if (value == "n")
                {
                    Console.WriteLine("Closing Calculator");
                    break;
                }

            } while (value.ToLower() == "y");
        }

        private void PerformOperation(List<float> numbers, List<string> symbols)//method for math functions
        {
            if (numbers.Count != symbols.Count + 1)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            float result = numbers[0];
            for (int i = 0; i < symbols.Count; i++)
            {
                switch (symbols[i])
                {
                    case "+":
                        result += numbers[i + 1];
                        break;
                    case "-":
                        result -= numbers[i + 1];
                        break;
                    case "*":
                        result *= numbers[i + 1];
                        break;
                    case "/":
                        if (numbers[i + 1] == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed");
                            return;
                        }
                        result /= numbers[i + 1];
                        break;
                    default:
                        Console.WriteLine("Invalid symbol");
                        return;
                }
            }
            Console.WriteLine($"Result: {result}");
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
