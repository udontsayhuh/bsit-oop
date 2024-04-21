using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Call the CountWords function to count the number of words in the input string
        int wordCount = CountWords(input);

        // Convert the input string to uppercase
        string inputString = input.ToUpper();

        // Display the number of words and the uppercase version of the input string
        Console.WriteLine($"Number of Words: {wordCount}");
        Console.WriteLine($"Uppercase: {inputString}");
    }

    // Function to count the number of words in a string
    static int CountWords(string text)
    {
        int wordCount = 0;
        bool inWord = false; // Initialize a flag to track whether we are inside a word

        // Loop through each character in the input text
        foreach (char currentChar in text)
        {
            // Check if the current character is a letter or digit
            if (char.IsLetterOrDigit(currentChar))
            {
                if (!inWord)
                {
                    inWord = true;
                    wordCount++;
                }
            }
            else
            {
                inWord = false;
            }
        }

        return wordCount; // Return the final word count
    }

}
