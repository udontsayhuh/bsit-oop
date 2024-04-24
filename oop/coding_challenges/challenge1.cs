using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.coding_challenges
{
    internal class Challenge1
    {
        public int intnum, intnum2, intsum;
        public double doublenum, doublenum2, doublesum;
        public double product;

        public void Result()
        {
            Console.Write("Enter the first number: ");
            intnum = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            intnum2 = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the first number(ex. 10.9): ");
            doublenum = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number(ex. 10.9): ");
            doublenum2 = double.Parse(Console.ReadLine());

            intsum = intnum + intnum2;
            Console.WriteLine($"The sum of {intnum} and {intnum2} is {intsum}");
            
            doublesum = doublenum + doublenum2;
            Console.WriteLine($"The sum of {doublenum} and {doublenum2} is {doublesum}");

            product = intsum * doublesum;
            Console.WriteLine($"The product of {intsum} and {doublesum} is {product}");

            Console.WriteLine(" ");
        }
    }
}
