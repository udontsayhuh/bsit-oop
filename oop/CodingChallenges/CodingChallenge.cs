using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.CodingChallenges
{
    internal class CodingChallenge
    {
        public int isum;
        public double dsum;
        public int inum1 { get; set; }
        public int inum2 { get; set; }
        public double dnum1 { get; set; }
        public double dnum2 { get; set; }
        
        public void SumIntegers()
        {
            Console.Write("\nEnter your first integer: ");
            inum1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your second integer: ");
            inum2 = int.Parse(Console.ReadLine());
        }
        public void SumDouble()
        {
            Console.Write("Enter your first double (ex: 12.98): ");
            dnum1 = double.Parse(Console.ReadLine());
            Console.Write("Enter your second double (ex: 12.98): ");
            dnum2 = double.Parse(Console.ReadLine());
        }

    }
}
