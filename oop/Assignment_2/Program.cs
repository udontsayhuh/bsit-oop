using System;
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
            do
            {
                op.getNumbers();
                op.getOperation();

                bool a = true;
                do
                {
                    Console.WriteLine("Do you want to Continue Using Calculator? [Y or y] Yes, [N or n] No: ");
                    choice = Convert.ToChar(Console.ReadLine());

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
}
