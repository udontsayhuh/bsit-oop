using oop.ass2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oop.ass2
{
    internal class Compute
    {
        // Encapsulation of user input
        private double number1, total;
        //public char operators;
        //public double sum, difference, product, quotient;

        public double Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
    }

}
