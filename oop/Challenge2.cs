using System;

class Sentence
{
    public virtual void My_String()
    {
        Console.Write("\nEnter a string: ");
        string word = Console.ReadLine();

        string[] wrds = word.Split(' '); //split the sentence into words

        int wordCount = wrds.Length; //counts the words

        Console.Write($"\nNumber of Words: {wordCount}\n");

        string uppercase = word.ToUpper(); //changes the string into uppercase

        Console.Write($"\nUppercase: {uppercase}\n\n");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Sentence sentence = new Sentence(); //instantiate the class
        sentence.My_String(); //calls the method
    }

}