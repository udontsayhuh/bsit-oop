using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            char operation;
            double num1; 
            double num2;
            double num3;

            Console.WriteLine("Welcome to The Calculator");

            Console.Write("Enter First Number:");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number value!.");
                return;
            }
            
          

                Console.Write("Enter Second number:");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number value!.");
                return;
            }

            Console.Write("Enter Third number:");
            if (!double.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("Invalid input. Please enter a valid number value!.");
                return;
            }

            Console.WriteLine("Pick a Symbol Given Below.");
            Console.WriteLine("[+]");
            Console.WriteLine("[-]");
            Console.WriteLine("[*]");
            Console.WriteLine("[/]");
            Console.Write("Type Here:");
            operation = Console.ReadLine()[0];
            if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            {
                Console.WriteLine("Invalid operator. Please enter one of the four specified operators.");
                continue;
            }
             double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2 + num3;
                    Console.WriteLine("Addition:" + result);
                    break;
                case '-':
                    result = num1 - num2 - num3;
                    Console.WriteLine("Subtraction:" + result);
                    break;
                case '*':
                    result = num1 * num2 * num3;
                    Console.WriteLine("Multiplication:" + result);
                    break;
                case '/':
                    result = num1 / num2 / num3;
                    Console.WriteLine("Division:" + result);
                    break;
            }

           

           
            Console.Write("Do you want to perform another calculation? (Y/N): ");
            char choice = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (choice != 'Y')
            {
                break;
            }
  
    }
}
    }
