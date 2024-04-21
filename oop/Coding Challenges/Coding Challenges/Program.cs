using System;
using Coding_Challenges;

namespace Coding_Challenges {
    class Program
    {

        public static void Main(string[] args)
        {
            Input_AddMultiply input_AddMultiply = new Input_AddMultiply();
            ClearScreen();

            WordCount input_WordCount = new WordCount();
            ClearScreen();

            Arithmetic arithmetic = new Arithmetic();
            ClearScreen();

            MultiplicationTable multiplicationTable = new MultiplicationTable();
            ClearScreen();

            SortCars sortCars = new SortCars();
            ClearScreen();

        }

        public static void ClearScreen()
        {
            Console.WriteLine("\nPress Enter to Continue\n");
            Console.Read();
            Console.ReadLine();
            Console.Clear();
        }

    }

}
