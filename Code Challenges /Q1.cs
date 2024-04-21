using System;

class Program
{
   static void Main(string[] args)
   {

	  // Input
	  try
	  {
		 Console.Write("Enter first number: ");
		 int num_1 = int.Parse(Console.ReadLine());
		 Console.Write("Enter second number: ");
		 int num_2 = int.Parse(Console.ReadLine());
		 Console.WriteLine($"The sum is: {Add(num_1, num_2)} ");

		 Console.Write("\nEnter third number: ");
		 double num_3 = double.Parse(Console.ReadLine());
		 Console.Write("Enter fourth number: ");
		 double num_4 = double.Parse(Console.ReadLine());
		 Console.WriteLine($"The sum is: {Add((int)num_3, (int)num_4)} ");

		 // Computing for product
		 double prod = (double)(num_1 + num_2) * (num_3 + num_4);
		 Console.WriteLine($"\nThe product of two sums is {prod}.");

	  } // try

	  catch (FormatException)
	  {
		 Console.WriteLine("This program only accept numerical values!");
	  } // catch
	  finally
	  {
		 Console.WriteLine("\nProgram terminated!");
	  } // finally


   } // Main

   static int Add(int num_1, int num_2)
   {
	  return num_1 + num_2;
   }

} // Program
