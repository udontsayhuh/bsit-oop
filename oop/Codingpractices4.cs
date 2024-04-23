class MultiplicationTable
{
    static void Main(string[] args)
    {
      //User enters number to be multiplied
        Console.Write("Enter the number to be multiplied: ");
        int number = Convert.ToInt32(Console.ReadLine());

      // User enters the multiplier for the table
        Console.Write("Enter the multiplier: ");
        int multiplier = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Multiplication table for {number}:");

      //Program iterates till the number is less than or equal to the multiplier
        for (int i = 1; i <= multiplier; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
        }
    }
}
