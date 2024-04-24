using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.coding_challenges
{
    internal class Challenge3
    {
        public double num, num2, result;
        public bool use_again, retry = true, retryOperation = true;
        public char operation;
        public string response;

        public void Input()
        {
            Console.Write("Enter the first number: ");
            num = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
        }
        public void Compute()
        {
            do
            {
                while (retryOperation) 
                {
                    Console.WriteLine("Arithmetic Operators");
                    Console.WriteLine("[+] Add\n[-] Subtract\n[*] Multiply\n[/] Division");
                    Console.Write("Choose an operator: ");
                    operation = char.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case '+':
                            Input();
                            result = num + num2;
                            Console.WriteLine($"The sum of {num} and {num2} is {result}");
                            Console.WriteLine(" ");
                            break;

                        case '-':
                            Input();
                            result = num - num2;
                            Console.WriteLine($"The difference of {num} and {num2} is {result}");
                            Console.WriteLine(" ");
                            break;

                        case '*':
                            Input();
                            result = num * num2;
                            Console.WriteLine($"The product of {num} and {num2} is {result}");
                            Console.WriteLine(" ");
                            break;

                        case '/':
                            Input();
                            result = num / num2;
                            Console.WriteLine($"The quotient of {num} and {num2} is {result}");
                            Console.WriteLine(" ");
                            break;

                        default:
                            Console.WriteLine($"The operation is invalid.");
                            continue;
                    }
                } 

                while (retry)
                {
                    Console.WriteLine("Do you wish to calculate again?");
                    response = Console.ReadLine();
                    Console.WriteLine(" ");

                    if (response == "Yes" || response == "yes")
                    {
                        use_again = true;
                        break;
                    }
                    else if (response == "No" || response == "no")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Response. Try again.");
                        continue;
                    }
                }

            } while (use_again);
        }
    }
}
