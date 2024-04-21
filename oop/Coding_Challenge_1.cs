using System;
using System.ComponentModel;
using System.Xml.XPath;

namespace CrystalynDanga
{
       /* Write a C# program that contains method that accepts inputs from the user - that will
    compute the sum of two integers and two doubles separately, and after showing the
    result of the two sums, compute for the product of the sums - the result must be a
    double data type.*/
    class Program
    {
        // Addition method
        public static void Addition(int n1, int n2, double x1, double x2)
        {
            // Will compute for the result of both integers 
            int resultInt = n1 + n2;
            Console.WriteLine("\nThe value of both integers added: " + resultInt);

            // Will compute for the result of both doubles
            double resultDouble = x1 + x2;
            Console.WriteLine("\nThe value of both doubles added: " + resultDouble);

            // Passing values to the multiplication method
            Multiplication(resultInt, resultDouble); 
        } // Addition

        // Multiplication Method
        public static void Multiplication(int resultInt, double resultDouble)
        {
            // Will compute for the result of both sums
            double resultMultiplication = resultInt * resultDouble;
            Console.WriteLine("\nThe result of two sums multiplied: " + resultMultiplication);
        } // IntegerMultiplication
        public static void GetUserInput() // UserInput
        {
            // Integer Input
            Console.Write("Enter the first integer value: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer value: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            // Double Input
            Console.Write("Enter the first double value: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second double value: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            // Method Call for addition
            Addition(n1, n2, x1, x2);

        } // GetUserInput

        static void Main(string[] args) 
        {
            GetUserInput(); //Calling input method

        } // Main Method
    } // Program Class

} // Namespace
