/*Write a C# program that accepts a string and will count the number of words 
in the provided string and print the string in uppercase as a result.*/
using System;

class Program
{
  public static void Main()
  {
    //ask the user to enter a string (word/s)
    Console.WriteLine("Enter a string: ");
    //reads the user's input
    string input = Console.ReadLine();

    //count the number of words in the input string
    int WordCount = CountWords(input);
    string uppercaseString = input.ToUpper(); //convert the input string to uppercase

    //display the number of words
    Console.WriteLine($"Number of Words: {WordCount}");
    //display the input string in uppercase
    Console.WriteLine($"Uppercase String: {uppercaseString}");
  }

  public static int CountWords(string input)
  {
    //split the input string by whitespace characters
    string[] words = input.Split(new[] {' '});
    return words.Length; //return the number of words
  }
}
