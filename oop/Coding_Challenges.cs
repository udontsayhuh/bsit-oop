using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Test_Grounds
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("C# CODING CHALLENGES");
                Console.WriteLine("by: Garces, John Mark A.");
                Console.WriteLine("BSIT 2-1\n");
                Console.WriteLine("1 Coding Challenge #1 (2 Integer, 2 Double)");
                Console.WriteLine("2 Coding Challenge #2 (Word Count)");
                Console.WriteLine("3 Coding Challenge #3 (Arithmethic Functions)");
                Console.WriteLine("4 Coding Challenge #4 (Multiplication Table)");
                Console.WriteLine("5 Coding Challenge #5 (List Sorting)");
                Console.WriteLine("6 Exit\n");
                Console.Write("Enter Choice: ");
                string? choice = Console.ReadLine();
                if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6")
                {
                    Console.Clear();
                    Console.WriteLine("Enter Valid Choices Only.\n");
                }
                else if (choice == "6")
                    break;
                else
                {
                    Console.Clear();
                    switch (choice)
                    {
                        case "1":
                            SumAndMultiply();
                            break;
                        case "2":
                            CountWords();
                            break;
                        case "3":
                            ArithmeticFunctions();
                            break;
                        case "4":
                            MultiplicationTable();
                            break;
                        case "5":
                            SortList();
                            break;
                        default:
                            break;
                    }
                    Console.Clear();
                }
            }
        }

        static void SumAndMultiply() // QUESTION #1
        {
            int _int_1;
            int _int_2;
            int _int_sum;
            double _dbl_1;
            double _dbl_2;
            double _dbl_sum;
            double _product;

            while (true)
            {
                try
                {
                    Console.Write("Enter 1st Integer: ");
                    _int_1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter 2nd Integer: ");
                    _int_2 = Convert.ToInt32(Console.ReadLine());
                    _int_sum = _int_1 + _int_2;
                    break;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Enter Integers Only.\n");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter 1st Double: ");
                    _dbl_1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter 2nd Double: ");
                    _dbl_2 = Convert.ToDouble(Console.ReadLine());
                    _dbl_sum = _dbl_1 + _dbl_2;
                    break;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Enter Doubles Only.\n");
                }
            }
            _product = _int_sum * _dbl_sum;
            Console.WriteLine($"\n INTEGER SUM : {_int_1} + {_int_2} = {_int_sum}");
            Console.WriteLine($" DOUBLE SUM  : {_dbl_1} + {_dbl_2} = {_dbl_sum}");
            Console.WriteLine($"   PRODUCT   :  {_int_sum} * {_dbl_sum} = {_product}");
            Console.ReadKey();
        }

        static void CountWords() //QUESTION #2
        {
            string? _input;
            int _word_count = 0;
            bool _in_word = false;
            while (true)
            {
                Console.Write("Enter String: ");
                _input = Console.ReadLine();
                if (_input == null || _input == String.Empty)
                {
                    Console.Clear();
                    Console.WriteLine("Input cannot be null/empty.");
                }
                else
                    break;
            }

            for (int i = 0; i < _input.Length; i++)
            {
                if (char.IsLetterOrDigit(_input[i]) && !_in_word)  //Will consider any letter or number as a start of a word
                {
                    _in_word = true;
                    _word_count++;
                }
                else if (_input[i] == ' ') //ends a "word" if there is space
                    _in_word = false;
            }

            Console.WriteLine($"\nWORD COUNT: {_word_count}");
            Console.WriteLine($"STRING IN UPPERCASE: {_input.ToUpper()}");
            Console.ReadKey();
        }

        static void ArithmeticFunctions() //QUESTION #3
        {
            double _num_1;
            double _num_2;
            string? _operation;
            double? _result;
            string? _Y_or_N;

            do
            {
                while (true)
                {
                    Console.Write("Enter Operation ( + , - , * , / ): ");
                    _operation = Console.ReadLine();
                    if (_operation != "+" && _operation != "-" && _operation != "*" && _operation != "/")
                    {
                        Console.Clear();
                        Console.WriteLine("Enter Valid Operations Only.\n");
                    }
                    else
                        break;
                }

                while (true)
                {
                    try
                    {
                        Console.Write("Enter 1st Number: ");
                        _num_1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter 1st Number: ");
                        _num_2 = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Enter Valid Numbers Only.\n");
                    }
                }

                switch (_operation)
                {
                    case "+":
                        _result = _num_1 + _num_2;
                        break;
                    case "-":
                        _result = _num_1 - _num_2;
                        break;
                    case "*":
                        _result = _num_1 * _num_2;
                        break;
                    case "/":
                        if (_num_2 != 0)
                            _result = _num_1 / _num_2;
                        else
                        {
                            Console.WriteLine("Error: Cannot Divide by Zero.");
                            _result = null;
                        }
                        break;
                    default:
                        _result = null;
                        break;
                }

                Console.WriteLine($"\n{_num_1} {_operation} {_num_2} = {(_result == null ? "UNDEFINED" : _result)}\n");

                while (true)
                {
                    Console.Write("Compute Again? (Y/N): ");
                    _Y_or_N = Console.ReadLine()?.ToUpper();
                    if (_Y_or_N != "Y" && _Y_or_N != "N")
                    {
                        Console.Clear();
                        Console.WriteLine("Enter Y or N only.\n");
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                }
            } while (_Y_or_N == "Y");
        }

        static void MultiplicationTable()//QUESTION #4
        {
            int? _num;
            int? _multiplier;
            while (true)
            {
                try
                {
                    Console.Write("Enter number: ");
                    _num = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter multiplier: ");
                    _multiplier = Convert.ToInt32(Console.ReadLine());
                    if (_multiplier < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Multiplier can only be positive.\n");
                    }
                    else
                        break;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Enter Integers Only.\n");
                }
            }

            Console.WriteLine();
            for (int i = 1; i <= _multiplier; i++)
            {
                Console.WriteLine($"{_num} x {i} = {_num * i}");
            }
            Console.ReadKey();
        }

        static void SortList() //QUESTION #5
        {
            List<string> list = new List<string>();
            list.Add("Toyota");
            list.Add("Honda");
            list.Add("Tesla");
            list.Add("Ford");
            list.Add("Nissan");

            Console.Write("ORIGINAL LIST: ");
            foreach (var element in list)
                Console.Write($"{element} ");

            list.Sort();

            Console.Write("\nSORTED LIST: ");
            foreach (var element in list)
                Console.Write($"{element} ");
            Console.ReadKey();
        }
    }
}
// GARCES, JOHN MARK A.
// BSIT 2-1
