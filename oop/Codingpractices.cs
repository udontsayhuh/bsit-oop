class Compute
{
    static void Main(string[] args)
    {
        // Input for two integers
        Console.Write("Enter the first integer: ");
        int int1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int int2 = Convert.ToInt32(Console.ReadLine());

        // Input for two doubles
        Console.Write("Enter the first double: ");
        double double1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second double: ");
        double double2 = Convert.ToDouble(Console.ReadLine());

        // Compute the sum of integers
        int intSum = Sum(int1, int2);
        Console.WriteLine($"Sum of integers: {intSum}");

        // Compute the sum of doubles
        double doubleSum = Sum(double1, double2);
        Console.WriteLine($"Sum of doubles: {doubleSum}");

        // Compute the product of the sums
        double product = intSum * doubleSum;
        Console.WriteLine($"Product of the sums: {product}");
    }

    // Method to compute the sum of two integers
    static int Sum(int a, int b)
    {
        return a + b;
    }

    // Method to compute the sum of two doubles
    static double Sum(double a, double b)
    {
        return a + b;
    }
}
//Lennox Macadangdang BSIT 2-1
// The program uses int and double for the numbers and also it displays the product of the sums. 
