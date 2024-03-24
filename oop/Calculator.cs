//calculator.cs mrccdrcmyg

class Input
{
    public string operand;
    public float num1;
    public float num2;

    public Input (float num1, string operand, float num2)
    {
        this.num1 = num1;
        this.num2 = num2;   
        this.operand = operand;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Input newInput = new Input("test", 1, 2);
    }
}
    