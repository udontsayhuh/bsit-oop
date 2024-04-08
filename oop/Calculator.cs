// Base Class
abstract class Operator
{
    public abstract double Calculate(double num1, double num2);
}

// Subclass for Addition
class Add : Operator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 + num2;
    }
}

// Subclass for Subtraction
class Subtract : Operator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 - num2;
    }
}

// Subclass for Multiplication
class Multiply : Operator
{
    public override double Calculate(double num1, double num2)
    {
        return num1 * num2;
    }
}

// Subclass for Division
class Divide : Operator
{
    public override double Calculate(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
}

class Calculator
{
    static void Main(string[] args)
    {
        bool repeat = true;

        while (repeat)
        {
            double result = 0;

            bool validInput = false;
            while (!validInput)
            {
                validInput = true;
                while (true)
                {
                    Console.WriteLine("Enter a number, operator (+, -, *, /), or = to calculate:");
                    string input = Console.ReadLine();

                    if (input == "=")
                    {
                        break;
                    }

                    double number;
                    bool isValidNumber = double.TryParse(input, out number);

                    if (!isValidNumber && input != "+" && input != "-" && input != "*" && input != "/")
                    {
                        Console.WriteLine("Invalid input. Please enter a number, operator (+, -, *, /), or = to calculate:");
                        validInput = false;
                        break;
                    }

                    if (result == 0)
                    {
                        result = number;
                    }
                    else
                    {
                        char operation = char.Parse(input);
                        Operator op = GetOperator(operation.ToString());

                        if (op != null)
                        {
                            Console.WriteLine("Enter the next number:");
                            double num2;
                            bool validNumberInput = double.TryParse(Console.ReadLine(), out num2);
                            if (!validNumberInput)
                            {
                                Console.WriteLine("Invalid number input. Please try again.");
                                validInput = false;
                                break;
                            }
                            result = op.Calculate(result, num2);
                        }
                        else
                        {
                            Console.WriteLine("Invalid operator.");
                            validInput = false;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Do you want to perform another calculation? (yes/no)");
            string response = Console.ReadLine();
            repeat = (response.ToLower() == "yes");
        }
    }

    static Operator GetOperator(string operation)
    {
        switch (operation)
        {
            case "+":
                return new Add();
            case "-":
                return new Subtract();
            case "*":
                return new Multiply();
            case "/":
                return new Divide();
            default:
                return null;
        }
    }
}
//Lennox Macadangdang BSIT 2-1
