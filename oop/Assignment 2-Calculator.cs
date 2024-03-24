using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculatorProgram
{
    static void Main(string[] args)
    {
        // User Input 1st Number
        double number1 = Validator("Please enter the first number: ");
    }
    
    // The checker, if user input is not a number
    static double Validator(string error)
    {
        double number;
        Console.Write(error);

        //
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Error! Please enter only numbers\n");
            Console.Write(error);
        }

        return number;
    }
}
namespace oop
{
    class Calculator
    {

    }

    
}