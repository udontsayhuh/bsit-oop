//mrccdricmyg

using System;

class Input
{
    public static void get_num()
    {
        Console.WriteLine("Enter an integer...");
        string num1 = Console.ReadLine();
    }
}

class Operator : Input
{

}

class Program
{
    static void Main(string[] args)
    {
        Input.get_num();
    }
}
