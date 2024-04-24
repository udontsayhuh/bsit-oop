using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.CodingChallenges
{
    internal class Sums : CodingChallenge
    {
        public int ISum(int num1, int num2)
        {
            isum = num1 + num2;
            return isum;
        }
        public double DSum(double num1, double num2)
        {
            dsum = num1 + num2;
            return dsum;
        }
        public void SumResult()
        {
            double prodOfSums;
            Console.WriteLine("\nCoding Challenges #1");
            SumIntegers();
            SumDouble();
            prodOfSums = ISum(inum1, inum2) * DSum(dnum1, dnum2);
            Console.WriteLine($"\nSum of Integers: {ISum(inum1, inum2)}");
            Console.WriteLine($"Sum of Double: {DSum(dnum1, dnum2)}");
            Console.WriteLine($"Product of Sums: {prodOfSums}\n");
        }
    }
}
