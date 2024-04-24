using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop.coding_challenges
{
    internal class Challenges_1_5
    {
        static void Main(string[] args)
        {
            int userChoice;
            while (true)
            {
                Console.WriteLine("Choose what challenge do you want to execute.\n");
                Console.WriteLine("[1] Challenge 1\n[2] Challenge 2\n[3] Challenge 3\n[4] Challenge 4\n[5] Challenge 5\n[0] Exit");
                Console.Write("\n -> ");
                userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 0)
                {
                    Console.WriteLine("\nThank you!");
                    Environment.Exit(0);
                }
                else if (userChoice == 1)
                {
                    Console.WriteLine("\nCHALLENGE NO. 1\n");
                    Challenge1 challenge1 = new Challenge1();
                    challenge1.Result();
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("\nCHALLENGE NO. 2\n");
                    Challenge2 challenge2 = new Challenge2();
                    challenge2.WordCount();
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("\nCHALLENGE NO. 3\n");
                    Challenge3 challenge3 = new Challenge3();
                    challenge3.Compute();
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("\nCHALLENGE NO. 4\n");
                    Challenge4 challenge4 = new Challenge4();
                    challenge4.Multiplication();
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine("\nCHALLENGE NO. 5\n");
                    Challenge5 challenge5 = new Challenge5();
                    challenge5.CarBrands();
                }
                else
                {
                    Console.WriteLine("Input invalid");
                    continue;
                }
            }
        }
    }
}
