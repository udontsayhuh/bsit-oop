using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.coding_challenges
{
    internal class Challenge4
    {
        public int basenum, multiplier, product;

        public void Multiplication()
        {
            Console.Write("Enter the base number: ");
            basenum = int.Parse(Console.ReadLine());
            Console.Write("Enter the multiplier: ");
            multiplier = int.Parse(Console.ReadLine());

            for(int i = 0; i <= multiplier; i++)
            {
                product = basenum * i;
                Console.WriteLine($"{basenum} x {i} = {product}");
            }

            Console.WriteLine(" ");
        }
    }
}
