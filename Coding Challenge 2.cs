using System;

//A program that count the number of words in the provided string
class WordCount
{
    public static void Main(string[] args)
    {
        string str1 = ("Hi! I am Yesha Perez"); //to initialized string
        string[] word = str1.Split(' '); //method to count the words of str1

        int countW = word.Length; //to count the length of the entered word in str1

        //to print the output in uppercase
        Console.WriteLine("ENTERED STRING: " + str1.ToUpper());
        Console.WriteLine("\nTHE NUMBER OF WORDS IN THE ENTERED STRING IS: " + countW);
    }
}