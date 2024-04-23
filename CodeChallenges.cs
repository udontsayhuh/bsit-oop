using System;

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

        Console.WriteLine("\nThis is a test");
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
        Console.Clear();
        CodeChallenges3.Calculator();
    }
    
}


//Code challenge# 3
// Write a C# program that can perform basic arithmetic functions. (Addition,
// Subtraction, Multiplication, and Division). The user must be allowed to select which
// arithmetic function he/she wants to use, and then they will be prompted to enter only two numbers after
// selecting the arithmetic function. Print the result afterwards, and then after printing
// ask the user if he/she wants toperform another action or not. If yes, repeat the
// program, if not terminate the program.

class CodeChallenges3
{
    public static void Calculator()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("    Code Challenge # 3   ");
        Console.WriteLine("=========================");

        Console.WriteLine("\nThis is a test");
        Console.Write("\nClick 'Enter' to move to the next challenge:");
        Console.ReadLine();

        Console.Clear();
        CodeChallenges4.Multiplier();
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

        Console.WriteLine("\nThis is a test");
        Console.Write("\nClick 'Enter' to move to the next challenge:");
        Console.ReadLine();

        Console.Clear();
        CodeChallenges2.Counter();
    }
    
}

//Code challenge# 5
// Write a C# program that demonstrates a list that contains 5 cars
// and display a sorted listed after. (Using ArrayList are LinkedList is allowed).

class CodeChallenges5
{
    public static void List()
    {
        Console.WriteLine("=========================");
        Console.WriteLine("    Code Challenge # 5   ");
        Console.WriteLine("=========================");

        Console.WriteLine("\nThis is a test");
        Console.Write("\nClick 'Enter' to move to the next challenge:");
        Console.ReadLine();
    }
    
}