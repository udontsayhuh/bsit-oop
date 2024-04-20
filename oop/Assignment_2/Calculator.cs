using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Assignment_2
{
    internal abstract class Calculator
    {
        private double num1, num2;
        protected double sum, diff, prod, quo;
        protected char operation { get; set; }
        public abstract void getNumbers(int i);
        public abstract void getOperation(int j, List<double> myList);

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
    }
}
