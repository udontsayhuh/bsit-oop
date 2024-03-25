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
                Console.WriteLine("Do you want to Continue Using Calculator? [Y or y] Yes, [N or n] No: ");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'Y' || choice == 'y');
            
        }
    }
}
