using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.CodingChallenges
{
    internal class Calculator
    {
        private double num1, num2;
        public double sum, diff, prod, quo;

        // Property for input numbers
        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double add(double num1, double num2)
        {
            sum = num1 + num2;
            return sum;

        }
        public double sub(double num1, double num2)
        {
            diff = num1 - num2;
            return diff;
        }
        public double mul(double num1, double num2)
        {
            prod = num1 * num2;
            return prod;
        }
        public double div(double num1, double num2)
        {
            quo = num1 / num2;
            return quo;
        }
    }
}
