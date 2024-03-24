//mrccdricmyg

using System;
using System.Runtime.CompilerServices;


class Input
{   

    public static string get_input()
    {   while (true)
        {
            return "string";
        }
   
    }

    public static float get_num()
    {   
        while (true)
        {
            Console.WriteLine("Enter an integer...");
            string input = Console.ReadLine();

            // Attempt to parse the input as a float
            if (!float.TryParse(input, out float result))
            {
                Console.WriteLine("The input is not numerical.");
                
            }
            else
            {
                float num1 = Convert.ToSingle(input);
                return num1;
            }
        }
    }

    public static float Calculate(float num1)
    {
        while (true) {
            Console.WriteLine("Enter an operator (+, -, *, /)...");
            string input = Console.ReadLine();

            switch (input)
            {
                case "+":
                    float result = num1 + (Input.get_num());
                    return result;
                case "-":
                    float result2 = num1 - (Input.get_num());
                    return result2;
                case "*":
                    float result3 = num1 * (Input.get_num());
                    return result3;
                case "/":
                    float result4 = num1 / (Input.get_num());
                    return result4;

            }
        }
    }

}


class Operator : Input
{

}

class Program
{
    static void Main(string[] args)
    {
        float result = Input.Calculate(Input.get_num());

        Console.WriteLine(result);
    }
}
