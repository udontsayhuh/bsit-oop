using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Assignment_2
{
    internal class Calculator
    {
        private int num1, num2;
        public int sum, diff, prod, quo;

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
    }

    class Operation : Calculator
    {

        public int add(int num1, int num2)
        {
            sum = num1 + num2;
            return sum;
        }
        public int sub(int num1, int num2)
        {
            diff = num1 - num2;
            return diff;
        }
        public int mul(int num1, int num2)
        {
            prod = num1 * num2;
            return prod;
        }
        public int div(int num1, int num2)
        {
            quo = num1 / num2;
            return quo;
        }
    }
}
