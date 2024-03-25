using System;

abstract class Calculator
{
  protected double num1;
  protected double num2;

  public abstract void Solve();

  public void AskUser()
  {
    Console.WriteLine("Enter a number: ");
    if(!double.TryParse(Console.ReadLine(), out num1))
    {
      Console.Clear();
      Console.WriteLine("Invalid input. Only NUMERIC input is accepted.\nProgram terminated.");
      Environment.Exit(0);
    }

    Console.WriteLine("Enter another number: ");
    if(!double.TryParse(Console.ReadLine(), out num2))
    {
      Console.Clear();
      Console.WriteLine("Invalid input. Only NUMERIC input is accepted.\nProgram terminated.");
      Environment.Exit(0);
    }
  }
}


class Addition : Calculator
{
      public override void Solve()
      {
        AskUser();
        double sum = num1 + num2;
        Console.WriteLine($"The sum of {num1} + {num2} is {sum}");
      }
}


class Subtraction : Calculator
{
      public override void Solve()
      {
        AskUser();
        double difference = num1 - num2;
        Console.WriteLine($"The difference of {num1} - {num2} is {difference}");
      }
}


class Multiplication : Calculator
{
      public override void Solve()
      {
        AskUser();
        double product = num1 * num2;
        Console.WriteLine($"The product of {num1} * {num2} is {product}");
      }
}


class Division : Calculator
{
      public override void Solve()
      {
        AskUser();
        if(num2 == 0)
        {
            Console.WriteLine("Syntax Error! Division by zero is invalid.\nProgram Terminated.");
            Environment.Exit(0);
        }
        double quotient = num1 / num2;
        Console.WriteLine($"The quotient of {num1} / {num2} is {quotient}");
      }
}


class Program
{
  static void Main(string[] args)
  {
    while (true)
    {
      Console.WriteLine("Choose an operation: ");
      Console.WriteLine("'+' for Addition");
      Console.WriteLine("'-' for Subtraction");
      Console.WriteLine("'*' for Multiplication");
      Console.WriteLine("'/' for Division");

      Console.WriteLine("Enter your chosen operation symbol: ");
      char operation = Console.ReadKey().KeyChar;
      Console.WriteLine();

      Calculator calculator;

      switch (operation)
      {
        case '+':
          calculator = new Addition();
          break;
        case '-':
          calculator = new Subtraction();
          break;
        case '*':
          calculator = new Multiplication();
          break;
        case '/':
          calculator = new Division();
          break;
        default:
          Console.Clear();
          Console.WriteLine("Invalid choice. Choose between +, -, *, / ONLY!");
          continue;
      }

      calculator.Solve();

            string response;
            do
            {
                Console.WriteLine("Do you want to try again (yes or no)?: ");
                response = Console.ReadLine().ToLower();
                if (response != "yes" && response != "no")
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Choose between 'yes' and 'no' only! ");
                }
            } while (response != "yes" && response != "no");

            if (response == "no")
            {
                Console.WriteLine("Program ends.");
                return;
            }
        }
    }
}
