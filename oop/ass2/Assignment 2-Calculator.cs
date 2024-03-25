using oop;
using oop.ass2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

class CalculatorProgram
{
    static void Main(string[] args)
    {
        bool useCalcuAgain = true;

        while (useCalcuAgain)
        {
            Operation op = new Operation();
            op.validator();
            op.operation();

            string response;
            bool validResponse = false;

            do
            {
                Console.WriteLine("\nDo you want to calculate again? (yes/no)");
                response = Console.ReadLine();

                if (response == "yes" || response == "YES" || response == "no" || response == "NO")
                {
                    validResponse = true;
                }
                else
                {
                    Console.WriteLine("Error. Please type 'yes' or 'no' only.\n");
                }
                
            } while (!validResponse) ;
            if (response == "yes" || response == "YES")
            {
                Console.WriteLine("/nYou may now use the calculator again.");
            }
            if (response == "no" || response == "NO")
            {
                useCalcuAgain = false;
            }
        }

        Console.WriteLine("\nThank you for using this calculator.");
    }
}