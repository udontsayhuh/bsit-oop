/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation();
            char choice;
            List<double> valueList = new List<double>();
            do
            {
                for (int i = 0; i <= valueList.Count; i++)
                {
                    op.getNumbers(i);
                    op.getOperation(i, valueList);
                }
                

                bool a = true;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Do you want to Continue Using Calculator? [Y or y] Yes, [N or n] No: ");
                    Console.ResetColor();
                    choice = char.Parse(Console.ReadLine());

                    if(choice == 'Y' || choice == 'y')
                    {
                        break;
                    }
                    else if(choice == 'N' || choice == 'n')
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        a = true;
                    }
                } while (a);
                
            } while (choice == 'Y' || choice == 'y');


            
        }
    }
}*/
