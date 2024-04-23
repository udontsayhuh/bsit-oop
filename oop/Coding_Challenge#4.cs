using System;

abstract class Multiplication // Base class (parent)
{
    public int Multiplicand { get; set; }
    public int Multiplier { get; set; }

    protected Multiplication(int valuet, int value)
    {
        Multiplicand = value;
        Multiplier = value;
    }

    public abstract void Display();
}

class Compute : Multiplication
{
    public Compute(int multiplicand, int multiplier) : base(multiplicand, multiplier)
    {
        this.Multiplicand = multiplicand;
        this.Multiplier = multiplier;
    }

    public override void Display()
    {
        for (int i = 1; i <= Multiplier; i++)
        {
            int product = Multiplicand * i;
            Console.WriteLine(Multiplicand + " * " + i + " = " + product);

        }
    }

}


class Bergado_Assignment
{
    static void Main(string[] args)
    {
        Console.Write("Enter your multiplicand: ");
        int multiplicand = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your multiplier: ");
        int multiplier = Convert.ToInt32(Console.ReadLine());
        Compute compute = new Compute(multiplicand, multiplier);
        compute.Display();



    }
}
