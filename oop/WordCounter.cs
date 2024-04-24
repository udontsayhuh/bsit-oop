using System;

/*
The methods below are declared as static to reduce memory usage instead of creating instances of each class.
This means that the methods are accessible through the type itself rather than the instance of the type.
The classes below follow the Single-Responsibility Principle as each class has only one responsibility.
*/

// Class Role: Get string input from the user
class StringInput {
    public static string? Str = null;       // Follows PascalNamingConvention because it is a property
    public static string GetStringInput() {
        Console.Write("Enter a string: ");
        Str = Console.ReadLine();
        return Str;
    }
}

// Class Role: Split the string inputted by the user based on the given characters below.
class StringSplitter {
    public static string[] SplitString(string str) {
        return str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    }
}

// Class Role: Display the uppercased string.
class StringDisplay {
    public static void DisplayString() {
        Console.WriteLine($"Uppercased String: {StringInput.Str.ToUpper()}");
    }
}

/*
    Below is a class that counts the number of words in a string in an accurate way. I used the Google Docs to understand how it counts the number
of words in a sentence or in the document. I observed that it does not consider or count a single symbol or a group of symbols as a word. 
Google Docs will only consider a group of symbols as a word if it contains at least one of alphanumeric character. Therefore using the 
Length property to count the number of words in a string will give an incorrect number of words as it considers and counts a single and group
of symbols as a word.
*/
class WordCounter {
    public static int CountWords(string[] words) {
        int numberOfWords = 0;
        string[] notAWord = { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "-", "=", "[", "]", "\\", ";", "'", ",", ".", "/", "{", "}", "|", ":", "<", ">", "?" };
        // If the word is fully alphabetic, it is counted as word.
        // If the word contains a set of symbols with at least one alphanumeric character, it is counted as a word.
        // Otherwise, the word is not a word.
        foreach (var word in words) {
            if (!ContainsSymbol(word, notAWord) || ContainsAlphanumeric(word)) {
                numberOfWords += 1;
            }
        }
        return numberOfWords;
    }

    // Method to check if a word contains any symbol
    private static bool ContainsSymbol(string word, string[] symbols) {
        foreach (var symbol in symbols) {
            if (word.Contains(symbol)) {
                return true;
            }
        }
        return false;
    }

    // Method to check if a word contains at least one alphanumeric character
    private static bool ContainsAlphanumeric(string word) {
        foreach (char c in word) {
            if (char.IsLetterOrDigit(c)) {
                return true;
            }
        }
        return false;
    }
}



// Class Role: Displays the number of words in the string inputted by the user.
class WordCounterProgram {
    public static void Main(string[] args) {
        Console.WriteLine("Welcome to Word Counter!\n");

        // Get string input then split the string into words
        string[] words = StringSplitter.SplitString(StringInput.GetStringInput());

        // Count and display the number of words in the inputted string
        Console.WriteLine($"Number of Words: {WordCounter.CountWords(words)}");

        // Display the uppercased string
        StringDisplay.DisplayString();
    }
}
