using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.CodingChallenges
{
    class Program 
    {

        static void Main(string[] args)
        {
            bool invalidResponse = true;
            Sums c1 = new Sums();
            CodingChallenge2 c2 = new CodingChallenge2();
            CodingChallenge3 c3 = new CodingChallenge3();
            CodingChallenge4 c4 = new CodingChallenge4();
            CodingChallenge5 c5 = new CodingChallenge5();
            do
            {
                Console.WriteLine("Coding Challenges");
                Console.Write("Select Number:\n[1]\n[2]\n[3]\n[4]\n[5]\n[0] EXIT\n-> ");
                int choice = int.Parse(Console.ReadLine());

                if(choice == 0)
                {
                    Environment.Exit(0);
                }
                else if(choice == 1)
                {
                    // Coding Challenge 1
                    c1.SumResult();
                }
                else if (choice == 2)
                {
                    // Coding Challenge 2
                    c2.CountWord();
                }
                else if (choice == 3)
                {
                    // Coding Challenge 3
                    c3.CalculatorResult();
                }
                else if (choice == 4)
                {
                    // Coding Challenge 4
                    c4.MultiplicationTableResult();
                }
                else if (choice == 5)
                {
                    // Coding Challenge 5
                    c5.Vehicle();
                }
                else
                {
                    Console.WriteLine("Input Invalid!\n");
                    continue;
                }
                
            } while (invalidResponse);
        }
    }
}
