using System;
using System.Collections;

//Code challenge# 1
// Write a C# program that contains method that accepts inputs from the user - that will
// compute the sum of two integers and two doubles separately, and after showing the
// result of the two sums, compute for the product of the sums - the result must be a
// double data type.

class CodeChallenges1
{
    public static void Main()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("    Code Challenge # 1   ");
        Console.WriteLine("=========================");

        Console.Write("\n> Enter two integers separated with space: ");
        string[] intStrs = Console.ReadLine().Split();
        int num1 = int.Parse(intStrs[0]);
        int num2 = int.Parse(intStrs[1]);

        Console.Write("> Enter two doubles separated with space: ");
        string[] doubStrs = Console.ReadLine().Split();
        double a = double.Parse(doubStrs[0]);
        double b = double.Parse(doubStrs[1]);

        int intSum = num1 + num2;
        Console.WriteLine($"\n  >> Sum of Integers: {intSum}");

        double doubSum = a + b;
        Console.WriteLine($"  >> Sum of Doubles: {doubSum}");

        double multi = intSum * doubSum;
        Console.WriteLine($"  >> Product of the Integers and Doubles: {multi}");

        Console.Write("\nClick 'Enter' to move to the next challenge");
        Console.ReadLine();
        Console.Clear();
        CodeChallenges2.Counter();
    }
}

//Code challenge# 2
// Write a C# program that accepts a string and will count the number of words in the
// provided string and print the string in uppercase as a result.

class CodeChallenges2
{
    public static void Counter()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("    Code Challenge # 2   ");
        Console.WriteLine("=========================");

        Console.Write("\nEnter string to be counted: ");
        string UserInp = Console.ReadLine();
        string upperCase = UserInp.ToUpper();
        int strCount = upperCase.Length;

        Console.WriteLine($"\n>> The string '{upperCase}' has {strCount} characters");
        
        Console.Write("\nClick 'Enter' to move to the next challenge");
        Console.ReadLine();
        Console.Clear();
        CodeChallenges3.Calculator();
    }
}


//Code challenge# 3
// Write a C# program that can perform basic arithmetic functions. (Addition,
// Subtraction, Multiplication, and Division). The user must be allowed to select which
// arithmetic function he/she wants to use, and then they will be prompted to enter only two numbers after
// selecting the arithmetic function. Print the result afterwards, and then after printing
// ask the user if he/she wants to perform another action or not. If yes, repeat the
// program, if not terminate the program.

class CodeChallenges3
{
    public static void Calculator()
    {
        string confirm;

        do
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=========================");
            Console.WriteLine("    Code Challenge # 3   ");
            Console.WriteLine("=========================");

            Console.WriteLine("\n————————————————————————————");
            Console.WriteLine("|   Choose an operation:    |");
            Console.WriteLine("|   >> Addition (+)         |");
            Console.WriteLine("|   >> Subtraction (-)      |");
            Console.WriteLine("|   >> Multiplication (*)   |");
            Console.WriteLine("|   >> Division (/)         |");
            Console.WriteLine("————————————————————————————");

            Console.Write("\nEnter the symbol of your choice: ");
            string choice = Console.ReadLine(); // Get user's choice for the operation

            Console.Write("\n  >> Enter the first integer: ");//first number
            int num1;
            while (!int.TryParse(Console.ReadLine(),out num1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("= WARNING: Invalid input for integer! Try again =");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n  >> Enter the first integer: ");
            }

            Console.Write("  >> Enter the second integer: ");//second number
            int num2;
            while (!int.TryParse(Console.ReadLine(),out num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("= WARNING: Invalid input for integer! Try again =");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n  >> Enter the first integer: ");
            }
            
            int result;

            switch (choice)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("\n    >> Addition: " + num1 + " + " + num2 + " = " + result + " <<");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("\n    >> Subtraction: " + num1 + " - " + num2 + " = " + result + " <<");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("\n    >> Multiplication: " + num1 + " * " + num2 + " = " + result + " <<");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("\n    >> Division: " + num1 + " / " + num2 + " = " + result + " <<");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("= WARNING: Cannot divide by zero! =\n");
                        Console.Clear();
                        continue;
                    }
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("= WARNING: Invalid choice! Try again =\n");
                    Console.Clear();
                    continue;
            }
            Console.Write("\nDo you want to calculate again? (y/n): ");
            confirm = Console.ReadLine().ToUpper();
            Console.Clear();
        }
        while (confirm == "Y" );

        if (confirm == "N")
        {
            Console.Write("\nClick 'Enter' to move to the next challenge");
            Console.ReadLine();
            Console.Clear();
            CodeChallenges4.Multiplier();
        }
    }
}

//Code challenge# 4
// Write a C# program that takes two numbers as input: the first
// number will be the number to be multiplied and the second
// number will be the multiplier, and prints its multiplication table up
// to the given second number (the multiplier).

class CodeChallenges4
{
    public static void Multiplier()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("    Code Challenge # 4   ");
        Console.WriteLine("=========================");

        int num,num1;
        Console.Write("\nEnter the first number (Number to be calculated): ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number (The Multiplier): ");
        num1 = Convert.ToInt32(Console.ReadLine());
    
        Console.WriteLine("\n >> Multiplcation Table << \n");
        for(int i = num; i <= num; i++)
        {
            for (int j = 1; j <= num1; j++)
            {
                int value = i * j;
                Console.Write("\t{0} * {1} = {2}\n", i, j, value);
            }
        }

        Console.Write("\nClick 'Enter' to move to the next challenge");
        Console.ReadLine();
        Console.Clear();
        CodeChallenges5.Cars();
    }
}

//Code challenge# 5
// Write a C# program that demonstrates a list that contains 5 cars
// and display a sorted listed after. (Using ArrayList are LinkedList is allowed).

class CodeChallenges5
{
    public static void Cars()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("    Code Challenge # 5   ");
        Console.WriteLine("=========================");

        ArrayList carList = new ArrayList();
        carList.Add("Mitsubishi");
        carList.Add("Toyota");
        carList.Add("Tesla");
        carList.Add("Audi");
        carList.Add("Miata");

        Console.WriteLine("\nArrayList before sort:");
        PrintArrayList(carList);

        carList.Sort();
        Console.WriteLine("\nArrayList after sort:");
        PrintArrayList(carList);

        Console.Write("\nThats the end! thank you!");
    }

    private static void PrintArrayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(">> " + item);
        }
    }
}