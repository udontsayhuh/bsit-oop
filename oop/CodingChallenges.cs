using System;
using System.Collections;
using System.Threading;

namespace CodingChallenges
{
    public class Problem1
    {
        public static double SumOperation()
        {
            try
            {
                Console.Write("Enter integer 1: ");
                int int1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter integer 2: ");
                int int2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter 1st double: ");
                double double1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter 2nd double: ");
                double double2 = Convert.ToDouble(Console.ReadLine());

                int intSum = int1 + int2;
                double doubleSum = double1 + double2;

                Console.WriteLine("Sum of two ints: \n" + intSum);
                Console.WriteLine("Sum of two doubles: \n" + doubleSum);

                return intSum * doubleSum;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input. Please enter valid numbers.");
                return 1; 
            }
        }
    }

    public class Problem2
    {
        public static void CountWordsAndCase(string input)
        {
            /*Write a C# program that accepts a string and will count the number of words in the
            provided string and print the string in uppercase as a result.*/
            {
                int wordCount = 0;
                bool inWord = false;


                foreach (char c in input)
                {

                    if (!char.IsWhiteSpace(c))
                    {
                        // If not already in a word, mark as in a word and increment word count
                        if (!inWord)
                        {
                            inWord = true;
                            wordCount++;
                        }
                    }
                    else
                    {
                        // If character is whitespace and already in a word, mark as not in a word
                        inWord = false;
                    }
                }

                Console.WriteLine("Word count: " +wordCount);
                string upperCaseString = input.ToUpper();
                Console.WriteLine("String: " + upperCaseString);
                Thread.Sleep(1000);
                Console.WriteLine("Press any key to continue: ");
                Console.ReadKey(true);
            }
        }
    }
        public class Problem3
    {
        public static void Calculator()
        {
            /*Write a C# program that can perform basic arithmetic functions.The user must be allowed to select which
            arithmetic function they want to use, and then they will be prompted to enter only two numbers after
            selecting the arithmetic function. Print the result afterwards, and then after printing
            ask the user if he/she wants to perform another action or not. If yes, repeat the
            program, if not terminate the program.*/
            do
            {
                try
                {
                    char operation = GetOperation();
                    double num1 = GetUserNumber("Enter the first number: ");
                    double num2 = GetUserNumber("Enter the second number: ");
                    double result = 0;

                    switch (operation)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 != 0)
                                result = num1 / num2;
                            else
                            {
                                Console.WriteLine("\nCannot divide by zero.\n");
                                continue;
                            }
                            break;
                        default:
                            Console.WriteLine("\nInvalid input");
                            continue;
                    }

                    Console.WriteLine("Result: " + result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }
               

            } while (PromptForAnotherCalculation());

            Console.WriteLine("\nProgram terminated.");
        }


        static bool PromptForAnotherCalculation()
        {
            while (true)
            {
                Console.Write("\nPerform another calculation? Type 'Yes' or 'No': ");
                string prompt = Console.ReadLine().Trim().ToLower();
                if (prompt == "yes")
                    return true;
                else if (prompt == "no")
                    return false;
                else
                    Console.WriteLine("\nInvalid input. Please enter 'Yes' or 'No'.");
            }
        }

        static char GetOperation()
        {
            char operation = ' ';
            while (true)
            {
                Console.Write("Enter an operation (+, -, *, /): ");
                string input = Console.ReadLine().Trim();
                if (input.Length == 1 && (input[0] == '+' || input[0] == '-' || input[0] == '*' || input[0] == '/')) // Check validity of input
                {
                    operation = input[0];
                    break;
                }
                else
                    Console.WriteLine("\nInvalid operation. Please enter a valid operation.");
            }
            return operation;
        }

        static double GetUserNumber(string message)
        {
            double number;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine().Trim();
                if (double.TryParse(input, out number))
                    return number;
                else
                    Console.WriteLine("\nInvalid input. Please enter a valid number.");
            }
        }
    }

    public class Problem4
    {
        public static void Multiplier()
        {

            /*Write a C# program that takes two numbers as input: the first
            number will be the number to be multiplied and the second
            number will be the multiplier, and prints its multiplication table up
            to the given second number (the multiplier)*/
            while(true)
            {
                try
                {
                    Console.WriteLine("Enter 1st number: ");
                    double number1 = Convert.ToDouble(Console.ReadLine().Trim());
                    Console.WriteLine("Enter 2nd number: ");
                    double number2 = Convert.ToDouble(Console.ReadLine().Trim());
                    for (int i = 1; i <= number2; i++)
                    {
                        double result = number1 * i; // Calculate the result
                        Console.WriteLine($"\n{number1} * {i} = {result}");

                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid input. Please enter valid numbers.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    

                }

            }
            Thread.Sleep(1000);
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey(true);
            

        }
    }

    public class Problem5
    {
        public static void CarLists()
        {
            /*Write a C# program that demonstrates a list that contains 5 cars
            and display a sorted listed after. (Using ArrayList are LinkedList is
            allowed).*/
            
            ArrayList cars = new ArrayList
            {
                
                "Toyota",
                "Chevy",
                "Ford",
                "BMW",
                "Audi"
            };

            Console.WriteLine("Original list of cars:");
            PrintList(cars);
            Thread.Sleep(1000);
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey(true);
            cars.Sort();

            Console.WriteLine("\nSorted list of cars:");
            PrintList(cars);
            Thread.Sleep(1000);
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey(true);
        }

        static void PrintList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);
            
            while (true)
            {
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Select a problem to execute:");
                Console.WriteLine("1. Problem 1 - Sum of Integers and Doubles");
                Console.WriteLine("2. Problem 2 - Count Words and Convert to Uppercase");
                Console.WriteLine("3. Problem 3 - Basic Calculator");
                Console.WriteLine("4. Problem 4 - Multiplication Table");
                Console.WriteLine("5. Problem 5 - Car Lists\n");

                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Problem 1:\n");
                        double product = Problem1.SumOperation();
                        Console.WriteLine("Product of sums: " + product);
                        Thread.Sleep(1000);
                        Console.WriteLine("Press any key to continue: ");
                        Console.ReadKey(true);
                        break;
                    case "2":
                        Console.WriteLine("Problem 2:\n");
                        Console.Write("Enter a string: ");
                        string input = Console.ReadLine();
                        Problem2.CountWordsAndCase(input);
                        break;
                    case "3":
                        Console.WriteLine("Problem 3:\n");
                        Problem3.Calculator();
                        break;
                    case "4":
                        Console.WriteLine("Problem 4:\n");
                        Problem4.Multiplier();
                        break;
                    case "5":
                        Console.WriteLine("Problem 5:\n");
                        Problem5.CarLists();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.\n");
                        Thread.Sleep(1000);
                       
                        break;
                }

                
            }

         
        }
    }
}

