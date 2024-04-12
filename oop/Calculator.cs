using System.Collections;

class Calculator
{
    private double num1;
    private double result;
    private char operator1;
    private char repeat;

    public void Calculate()
    {
        var arlist = new ArrayList();
        while (true)
        {
            Console.Clear();
            result = 0;
            operator1 = '+';
            arlist.Clear();

            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("(enter a number)");
                    if (arlist.Count != 0)
                    {
                        foreach (var item in arlist)
                        {
                            Console.Write($"{item} ");
                        }
                    }

                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Invalid number. Please enter a valid number.");
                        Console.ReadKey();
                        continue;
                    }
                    else if (operator1 == '/' && num1 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        Console.ReadKey();
                        result = 0;
                        operator1 = '+';
                        arlist.Clear();
                        continue;
                    }
                    else
                    {
                        arlist.Add(num1);
                        break;
                    }
                }

                switch (operator1)
                {
                    case '+':
                        result += num1;
                        break;
                    case '-':
                        result -= num1;
                        break;
                    case '*':
                        result *= num1;
                        break;
                    case '/':
                        if (num1 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            Console.ReadKey();
                            break;
                        }
                        result /= num1;
                        break;
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("(enter + - * / or = to calculate)");
                    if (arlist.Count != 0)
                    {
                        foreach (var item in arlist)
                        {
                            Console.Write($"{item} ");
                        }
                    }

                    if (!char.TryParse(Console.ReadLine(), out operator1))
                    {
                        Console.WriteLine("Invalid operator. Please enter a valid operator (+ - * / =).");
                        Console.ReadKey();
                        continue;
                    }

                    if (operator1 == '=')
                    {
                        arlist.Add(operator1);
                        break;
                    }
                    else if (!(operator1 == '+' || operator1 == '-' || operator1 == '*' || operator1 == '/'))
                    {
                        Console.WriteLine("Invalid operator. Please enter a valid operator (+ - * / =).");
                        Console.ReadKey();
                        continue;
                    }
                    else
                    {
                        arlist.Add(operator1);
                        break;
                    }
                }

                if (operator1 == '=')
                {
                    break;
                }
            }

            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    foreach (var item in arlist)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.Write($"{result}");

                    Console.Write("\n\nDo you want to continue? (Y/N): ");
                    if (!char.TryParse(Console.ReadLine().ToUpper(), out repeat) || !(repeat == 'Y' || repeat == 'N'))
                    {
                        Console.WriteLine("Invalid input. Please enter Y or N.");
                        Console.ReadKey();
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }


                if (repeat == 'N')
                {
                    Console.WriteLine("Program has terminated.");
                    Console.ReadKey();
                    return;
                }
                else if (repeat == 'Y')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter Y or N.");
                    Console.ReadKey();
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

// Only Encapsulation and Abstraction are used in this code.
// Encapsulation: The class Calculator is an example of encapsulation. It encapsulates the data and methods that operate on the data.
// Abstraction: The class Calculator is an example of abstraction. It hides the implementation details of the calculation process and provides a simple interface for the user to interact with.
