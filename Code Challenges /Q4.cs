class Program
{

   static void Main(string[] args)
   {

	  Console.Write("Enter first number: ");
	  float num_1 = float.Parse(Console.ReadLine());
	  Console.Write("Enter second number: ");
	  float num_2 = float.Parse(Console.ReadLine());
	  
    int size = (int)num_2;
	  float[] prod = new float[size];

	  for (int i = 0; i < size; i++)
	  {
		 prod[i] = num_1 * (1 + i);

	  } // for 

      Console.WriteLine("\nMultiplication Table: ");
	  for (int i = 0; i < size; i++)
	  {
         Console.WriteLine($"{num_1} * {i+1} = {prod[i]}");
	  }

   } // Main

} // Program

