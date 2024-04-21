using System;

namespace Coding_Challenges
{
    internal class Arithmetic
    {

        private char _operation;
        private bool isSecondInput;

        internal Arithmetic()
        {
            Console.WriteLine("\nArithmetic\n");

            do
            {
                isSecondInput = false;
                _operation = GetOperation();
                Console.WriteLine(GetResult(GetNum(), GetNum()));

            } while (TryAgain());
   
        }

        private double GetNum()
        {

            while (true)
            {
                try
                {
                    
                    Console.Write("Enter a Number: ");
                    double num = Convert.ToDouble(Console.ReadLine());

                    if (_operation == '/' && isSecondInput && num == 0)
                    {
                        Console.WriteLine("\nCannot Divide By 0!\n");
                        continue;
                    }
                    else
                        isSecondInput = true;

                    return num;

                }

                catch (FormatException e)
                {

                    Console.WriteLine("\nInvalid Input\nTry Again!");

                }
            }
        }

        private char GetOperation()
        {

            while (true)
            {
                char operation = ' ';

                while (operation != '+' && operation != '-' && operation != '*' && operation != '/')
                {
                    Console.Write("Enter an Operation (+,-,*,/): ");
                    operation = Convert.ToChar(Console.Read());
                    Console.ReadLine();

                }

                return operation;

            }

        }

        private string GetResult(double x, double y)
        {
            switch(_operation){
                case '+':
                    return $"{x} + {y} = {x + y}";
                case '-':
                    return $"{x} - {y} = {x - y}";
                case '*':
                    return $"{x} * {y} = {x * y}";
                case '/':
                    return $"{x} / {y} = {x / y}";
                default:
                    return "";
            }
        }

        private bool TryAgain()
        {
            char reply = ' ';

            while (reply != 'Y' && reply != 'N')
            {

                Console.Write("\nWould you like to input again? (Y:N): ");
                reply = Char.ToUpper(Convert.ToChar(Console.Read()));
                Console.ReadLine();

            }

            return (reply == 'Y') ? true : false;
        }

    }
}