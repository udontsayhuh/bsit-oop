// modify version
// this calculator will continue until the user enters a "=" sign

using System;

class MyCalculator
{
   public void Start()
   {
	  Console.WriteLine("Calculator!");
	  Console.WriteLine("Press '=' to stop: \n");
	  SubMenu();
   }

   // subMenu
   private void SubMenu()
   {
	  float num1 = InputNum();
	  char op = InputOp();
	  float num2 = 0; // Initialize num_2

	  while (op != '=')
	  {
		 num2 = InputNum();

		 switch (op)
		 {
			case '+':
			   num1 = Add(num1, num2);
			   break;
			case '-':
			   num1 = Sub(num1, num2);
			   break;
			case '*':
			   num1 = Prod(num1, num2);
			   break;
			case '/':
			   num1 = Quo(num1, num2);
			   break;
		 } // switch

		 op = InputOp(); // next operator
	  } // while

	  Console.WriteLine($"\nFinal result: {num1}");
	  Continue(); // calling submenu if the user's input is Yes
   } // subMenu


   // for Input
   private float InputNum()
   {
	  float num;
	  string input;
	  do
	  {
		 Console.Write("Enter a number: ");
		 input = Console.ReadLine();
	  } while (!float.TryParse(input, out num));

	  return num;
   } // inputNum


   // for Input Operator
   private char InputOp()
   {
	  char op;
	  do
	  {
		 Console.Write("Enter operator (+, -, *, /, =): ");
		 op = Console.ReadKey().KeyChar;
		 Console.WriteLine();
	  } while (op != '+' && op != '-' && op != '*' && op != '/' && op != '=');

	  return op;
   } // inputNum

   private float Add(float num1, float num2)
   {
	  return num1 + num2;
   } // Add

   private float Sub(float num1, float num2)
   {
	  return num1 - num2;
   } // Sub

   private float Prod(float num1, float num2)
   {
	  return num1 * num2;
   } // Prod

   private float Quo(float num1, float num2)
   {
	  if (num2 == 0)
	  {
		 Console.WriteLine("Cannot divide by zero.");
		 return num1;
	  }
	  return num1 / num2;
   } // Quo

   private void Continue()
   {
	  Console.Write("\nDo you want to continue? (Y/N): ");
	  char choice = Console.ReadKey().KeyChar;

	  if (choice == 'Y' || choice == 'y')
	  {
		 Console.WriteLine("\n");
		 SubMenu();
	  }
   } // Continue
} // MyCalculator

class Program_Entry
{
   static void Main(string[] args)
   {
	  MyCalculator calculator = new MyCalculator();
	  calculator.Start(); // accessing the class using this method
   }
} // Program_Entry

