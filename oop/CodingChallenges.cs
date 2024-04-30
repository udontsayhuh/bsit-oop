using Exercise_1;
using Exercise_3;
using System.Collections;
using System.Text.RegularExpressions;

namespace MainProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise_1.Program.Main1();
            PauseAndClear();
            Exercise_2.Program.Main2();
            PauseAndClear();
            Exercise_3.Program.Main3();
            PauseAndClear();
            Exercise_4.Program.Main4();
            PauseAndClear();
            Exercise_5.Program.Main5();
            PauseAndExit();
        }

        public static void PauseAndClear()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void PauseAndExit()
        {
            Console.Write("\nPress any key to exit the program...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

namespace Exercise_1
{
    /* Write a C# program that contains method that accepts inputs from the user - that will
    compute the sum of two integers and two doubles separately, and after showing the
    result of the two sums, compute for the product of the sums - the result must be a
    double data type. */

    class Operation : Exercise_3.BaseOperation
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    class InputData
    {
        private int num1;
        private int num2;
        private double num3;
        private double num4;

        public InputData(int n1, int n2, double n3, double n4)
        {
            num1 = n1;
            num2 = n2;
            num3 = n3;
            num4 = n4;
        }

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double Num3
        {
            get { return num3; }
            set { num3 = value; }
        }

        public double Num4
        {
            get { return num4; }
            set { num4 = value; }
        }

        public static int ReadInteger(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid integer.");
                }
            }
        }

        public static double ReadDouble(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid double.");
                }
            }
        }
    }

    class Program
    {
        public static void Main1()
        {
            Console.WriteLine("Exercise 1: You need to input two integers and two doubles.");
            int num1 = InputData.ReadInteger("\nEnter the first integer: ");
            int num2 = InputData.ReadInteger("\nEnter the second integer: ");
            double num3 = InputData.ReadDouble("\nEnter the first double: ");
            double num4 = InputData.ReadDouble("\nEnter the second double: ");

            InputData inputData = new(num1, num2, num3, num4);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sum of two integers: " + Operation.Add(inputData.Num1, inputData.Num2));
            Console.WriteLine("Sum of two doubles: " + Operation.Add(inputData.Num3, inputData.Num4).ToString("F2"));
            Console.WriteLine("Product of the sums: " + Operation.Multiply(Operation.Add(inputData.Num1, inputData.Num2), Operation.Add(inputData.Num3, inputData.Num4)).ToString("F2"));
        }
    }
}

namespace Exercise_2
{
    /* Write a C# program that accepts a string and will count the number of words in the
    provided string and print the string in uppercase as a result. */
    class Program
    {
        static int CountWords(string text)
        {
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public static void Main2()
        {
            bool validInput = false;
            string input = "";

            Console.WriteLine("Exercise 2: You need to input string.");

            while (!validInput)
            {
                try
                {
                    Console.Write("\nEnter a string:");
                    input = Console.ReadLine();

                    if (!string.IsNullOrEmpty(input))
                    {
                        // Check if the input is a valid integer
                        if (int.TryParse(input, out _))
                        {
                            Console.WriteLine("Error: Please enter a non-numeric string.");
                        }
                        else if (double.TryParse(input, out _))
                        {
                            Console.WriteLine("Error: Please enter a non-numeric string.");
                        }
                        else if (Regex.IsMatch(input, @"[^a-zA-Z\s]"))
                        {
                            Console.WriteLine("Error: Please enter a string without special characters.");
                        }
                        else
                        {
                            validInput = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a non-empty string.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            int wordCount = CountWords(input);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Number of words: " + wordCount);
            Console.WriteLine("Uppercase String: " + input.ToUpper());
        }
    }
}

namespace Exercise_3
{
    /* Write a C# program that can perform basic arithmetic functions. (Addition,
    Subtraction, Multiplication, and Division). The user must be allowed to select which
    arithmetic function he/she wants to use, and then they will be prompted to enter only
    two numbers after selecting the arithmetic function.Print the result afterwards,
    and then after printing ask the user if he/she wants to perform another action or not.
    If yes, repeat the program, if not terminate the program. */

    class BaseOperation
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }

    class Program
    {
        public static void Main3()
        {
            bool repeat = true;

            while (repeat)
            {
                char choice;

                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Exercise 3: Basic Arithmetic Function.");
                        Console.WriteLine("\nSelect an arithmetic operation:");
                        Console.WriteLine(" (+)  Addition");
                        Console.WriteLine(" (-)  Subtraction");
                        Console.WriteLine(" (*)  Multiplication");
                        Console.WriteLine(" (/)  Division");

                        Console.Write("\nEnter your choice: ");
                        choice = Convert.ToChar(Console.ReadLine());

                        if (choice == '+' || choice == '-' || choice == '*' || choice == '/')
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please enter a valid arithmetic operation.");
                            MainProg.Program.PauseAndClear();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Please enter valid arithmetic operation.");
                        MainProg.Program.PauseAndClear();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                        MainProg.Program.PauseAndClear();
                    }

                }

                double num1 = InputData.ReadDouble("\nEnter the first number: ");
                double num2 = InputData.ReadDouble("\nEnter the second number: ");

                switch (choice)
                {
                    case '+':
                        Console.WriteLine("\nResult: " + BaseOperation.Add(num1, num2));
                        break;
                    case '-':
                        Console.WriteLine("\nResult: " + BaseOperation.Subtract(num1, num2));
                        break;
                    case '*':
                        Console.WriteLine("\nResult: " + BaseOperation.Multiply(num1, num2));
                        break;
                    case '/':
                        Console.WriteLine("\nResult: " + BaseOperation.Divide(num1, num2));
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice.");
                        break;
                }

                while (true)
                {
                    Console.Write("\nDo you want to perform another action (yes/no)? ");
                    string response = Console.ReadLine();
                    if (response.ToLower() == "no")
                    {
                        repeat = false;
                        break;
                    }
                    else if (response.ToLower() == "yes")
                    {
                        repeat = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.");
                    }
                }
            }
        }
    }
}

namespace Exercise_4
{
    /* Write a C# program that takes two numbers as input: the first
    number will be the number to be multiplied and the second
    number will be the multiplier, and prints its multiplication table up
    to the given second number(the multiplier). */

    class Program
    {
        public static void Main4()
        {
            Console.Clear();
            Console.WriteLine("Exercise 4: Multiplication Table");
            int number = InputData.ReadInteger("\nEnter the number to be multiplied: ");
            int multiplier = InputData.ReadInteger("\nEnter the multiplier: ");

            Console.WriteLine($"\nMultiplication Table for {number} up to {multiplier}:");
            PrintMultiplicationTable(number, multiplier);
        }

        static void PrintMultiplicationTable(int number, int multiplier)
        {
            for (int i = 1; i <= multiplier; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}

namespace Exercise_5
{
    /* Write a C# program that demonstrates a list that contains 5 cars
    and display a sorted listed after. (Using ArrayList are LinkedList is
    allowed). */

    class Program
    {
        public static void Main5()
        {
            Console.Clear();
            Console.WriteLine("Exercise 5: Sorted List of Cars");
            ArrayList cars = new() { "Toyota", "Dodge", "Bentley", "Cadillac", "Ferrari" };


            Console.WriteLine("\nOriginal List:");
            PrintList(cars);

            cars.Sort();
            Console.WriteLine("\nSorted List:");
            PrintList(cars);
        }

        static void PrintList(ArrayList list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

/*
Encapsulation: Encapsulation is about bundling the data(attributes) and methods(behaviors)
that operate on the data into a single unit called a class. In your code: Each class
(Operation, InputData, BaseOperation, Program in different namespaces) encapsulates related
functionality and data. For example, InputData encapsulates data related to input values
and methods to read input.

Inheritance: Inheritance is the mechanism where one class inherits properties and behaviors
from another class. In your code: Operation inherits from BaseOperation to reuse arithmetic
operation methods like Add, Subtract, etc.

Polymorphism: Polymorphism allows objects to be treated as instances of their parent class
or interfaces, enabling flexibility and extensibility. In your code: Polymorphism is implicitly
used in method calls like Operation.Add and BaseOperation.Add, where the specific method to
execute is determined dynamically based on the object's type.

Abstraction: Abstraction involves hiding the complex implementation details and exposing
only the necessary functionalities. In your code: Classes like Operation, InputData, and
BaseOperation provide abstractions of mathematical operations, user input handling, and basic
arithmetic functions without exposing their internal workings.
*/
