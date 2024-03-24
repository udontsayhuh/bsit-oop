using System;

abstract class MyCalculator
{
	public float Num_1;
	public float Num_2;
	public char Op;

	// constructor
	public MyCalculator(float Num_1, float Num_2, char Op)
	{

		this.Num_1 = Num_1;
		this.Num_2 = Num_2;
		this.Op = Op;

	} // MyCalc

	// method
	public abstract void Operate();

} // MyClass

class MyCalc : MyCalculator
{

	// constructor
	public MyCalc(float Num_1, float Num_2, char Op) : base(Num_1, Num_2, Op) { }
   
	public override void Operate()
	{
		// method 

		float result = 0;
		switch (Op)
		{
			case '+':
				result = Num_1 + Num_2;
				Console.WriteLine($"{Num_1} + {Num_2} = {result}");
				break;

			case '-':
				result = Num_1 - Num_2;
				Console.WriteLine($"{Num_1} - {Num_2} = {result}");
				break;

			case '*':
				result = Num_1 * Num_2;
				Console.WriteLine($"{Num_1} * {Num_2} = {result}");
				break;

			case '/':
				if (Num_2 != 0)
				{
					result = Num_1 / Num_2;
					Console.WriteLine($"{Num_1} / {Num_2} = {result}");
				}
				else
					Console.WriteLine("Error! Division by zero.");
				break;

				/*	default:
						Console.WriteLine("Error! Invalid Operator!");
						break;
				*/

		} // switch


	} // Operate
}

//

namespace Afable_Lawrence
{
	class Program_Entry
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Calculator!");
			SubMenu();
		} // Main

		static void SubMenu()
		{
			try
			{

				float num_1 = 0;
				float num_2 = 0;
				char op;

				// input
				Console.Write("\nEnter the first number: ");
				num_1 = float.Parse(Console.ReadLine());
				
                do {
				Console.Write("Enter operator (+, -, *, /): ");
				op = Console.ReadKey().KeyChar;
				Console.WriteLine();

				if (op != '+' && op != '-' && op != '*' && op != '/')
				{
					// throw new InvalidOperationException();
					Console.WriteLine("Error operator!\n");
				}
				else
				{
					Console.Write("Enter the second number: ");
					num_2 = float.Parse(Console.ReadLine());

				} // else
				
				} while (op != '+' && op != '-' && op != '*' && op != '/');// do

				// command
				MyCalc mycalc = new MyCalc(num_1, num_2, op);
				mycalc.Operate();
				cont();

			} // try

			catch (FormatException)
			{
				Console.WriteLine("This program only accept numerical values!");
			}
			/*catch (InvalidOperationException)
			{
				Console.WriteLine("Invalid Operator!");
			}*/
			finally
			{
				Console.WriteLine("\nProgram terminated!");
			}


		} // subMenu


		static void cont()
		{
			Console.Write("\nDo you want to continue? (Y/N): ");
			char cho = Console.ReadKey().KeyChar;

			if (cho == 'Y' || cho == 'y')
			{
				SubMenu();
			}
			else
			{
				return;
			}
		} // Cont

	} // program entry
} // namespace


