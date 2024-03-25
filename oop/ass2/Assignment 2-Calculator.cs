using oop;
using oop.ass2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

class CalculatorProgram
{
    static void Main(string[] args)
    {
        Operation op = new Operation();
        op.validator();
        op.operation();

    }
}