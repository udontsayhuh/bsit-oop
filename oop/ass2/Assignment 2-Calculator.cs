//using oop;
//using oop.ass2;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Numerics;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//class CalculatorMainProgram
//{
//    static void Main(string[] args)
//    {
//        bool useCalculatorAgain = true;

//        while (useCalculatorAgain) //to use the calculator again
//        {
//            Operation op = new Operation();
//            op.Compute();                     //calling the validator method which includes the user input w/validations

//            string response;
//            bool validResponse = false;         //validation for user response

//            do
//            {
//                Console.WriteLine("\nDo you want to calculate again? (yes/no)");
//                response = Console.ReadLine();

//                if (response == "yes" || response == "YES" || response == "no" || response == "NO") //checks whether the response are valud considering the cases
//                {
//                    validResponse = true;
//                }
//                else
//                {
//                    Console.WriteLine("Error. Please type 'yes' or 'no' only.\n");      //error message
//                }
                
//            } while (!validResponse) ;
//            if (response == "yes" || response == "YES")
//            {
//                Console.WriteLine("\nYou may now use the calculator again.\n");
//            }
//            if (response == "no" || response == "NO")
//            {
//                useCalculatorAgain = false;                                                  // to stop the loop
//            }
//        }

//        Console.WriteLine("\nThank you for using this calculator.");
//    }
//}
