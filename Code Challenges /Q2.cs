using System;

class Program
{
    static void Main(string[] args)
    {
        // Input
        Console.Write("Enter something: ");
        string str = Console.ReadLine();

        int count = 0;
        bool inWord = false;

        foreach (char c in str)
        {
            if (char.IsWhiteSpace(c))
            {
                if (inWord)
                {
                    count++;
                    inWord = false;
                }
            }
            else
            {
                inWord = true;
            }
        }

        if (inWord)
        {
            count++;
        }

        Console.WriteLine($"There are {count} word/s in \"{str.ToUpper()}\".");
    }
}

