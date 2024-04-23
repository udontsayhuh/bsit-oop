class StringCounter
{
  static void Main(string[] args)
  {
    Console.WriteLine("Enter a string:"); 
    string input = Console.ReadLine();

    //Count the number of words
            int wordCount = CountWords(input);
        Console.WriteLine($"Number of words in the string: {wordCount}");

        // Convert the string to uppercase
        string uppercaseString = input.ToUpper();
        Console.WriteLine($"Uppercase string: {uppercaseString}");
    }

    // Method to count the number of words in a string
    static int CountWords(string input)
    {
        // Split the string into words using whitespace as delimiter
        string[] words = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
//Lennox Macadangdang BSIT 2-1
