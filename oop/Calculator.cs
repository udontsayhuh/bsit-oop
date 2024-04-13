using System;
using System.Collections;

class BaseCalculator
{
    protected double numberInput;
    protected double calculatorResult;
    protected char operatorInput;
    protected char repeatCalculate;
    protected readonly ArrayList inputList;

    // Constructor
    public BaseCalculator()
    {
        numberInput = 0;
        calculatorResult = 0;
        operatorInput = '+';
        inputList = [];
    }

    protected virtual void DefaultValues()
    {
        calculatorResult = 0;
        operatorInput = '+';
        inputList.Clear();
    }

    public virtual void Calculate()
    {
    }

    protected virtual void UserInput()
    {
    }

    protected virtual void PerformCalculation()
    {
    }

    protected virtual void DisplayList()
    {
    }
}

class GeneralCalculator : BaseCalculator
{
    public override void Calculate()
    {
        Console.Clear();
        DefaultValues();
        UserInput();
    }

    protected override void UserInput()
    {
        while (true)
        {
            // Number Input
            while (true)
            {
                Console.Clear();
                Console.WriteLine("(enter a number)");
                DisplayList();

                try
                {
                    numberInput = double.Parse(Console.ReadLine());

                    if (operatorInput == '/' && numberInput == 0)
                    {
                        Console.WriteLine("\nError! Cannot divide by zero!");
                        Console.ReadKey();
                        DefaultValues();
                        continue;
                    }

                    inputList.Add(numberInput);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid numeric value.");
                    Console.ReadKey();
                    continue;
                }
            }

            PerformCalculation();

            // Operator Input
            while (true)
            {
                Console.Clear();
                Console.WriteLine("(enter + - * / or = to calculate)");
                DisplayList();

                try
                {
                    operatorInput = char.Parse(Console.ReadLine().Trim());

                    if (operatorInput != '+' && operatorInput != '-' && operatorInput != '*' && operatorInput != '/' && operatorInput != '=')
                    {
                        Console.WriteLine("\nInvalid operator. Please enter a valid operator (+ - * / =).");
                        Console.ReadKey();
                        continue;
                    }
                    else
                    {
                        inputList.Add(operatorInput);
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid operator. Please enter a valid operator (+ - * / =).");
                    Console.ReadKey();
                    continue;
                }
            }

            if (operatorInput == '=')
            {
                return;
            }
        }
    }

    protected override void PerformCalculation()
    {
        switch (operatorInput)
        {
            case '+':
                calculatorResult += numberInput;
                break;
            case '-':
                calculatorResult -= numberInput;
                break;
            case '*':
                calculatorResult *= numberInput;
                break;
            case '/':
                calculatorResult /= numberInput;
                break;
        }
    }

    protected override void DisplayList()
    {
        if (inputList.Count != 0)
        {
            foreach (var item in inputList)
            {
                Console.Write($"{item} ");
            }
        }

    }

    public bool AskForRepeat()
    {
        while (true)
        {
            Console.Clear();
            Console.Write("\n");
            DisplayList();
            Console.Write($"{calculatorResult}\n");
            Console.Write("\nDo you want to continue? (Y/N): ");

            try
            {
                repeatCalculate = char.Parse(Console.ReadLine().Trim().ToUpper());
                if (repeatCalculate == 'N')
                {
                    Console.WriteLine("\nExiting Calculator...");
                    Console.ReadKey();
                    return false;
                }
                else if (repeatCalculate == 'Y')
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter either Y to continue or N to terminate the program.");
                    Console.ReadKey();
                    continue;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input. Please enter either Y to continue or N to terminate the program.");
                Console.ReadKey();
                continue;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        GeneralCalculator calculator = new();

        while (true)
        {
            calculator.Calculate(); // Start the calculation process
            if (!calculator.AskForRepeat()) break; // Ask if the user wants to repeat the calculation
        }
    }
}

// Encapsulation: Encapsulation is implemented through the use of private and protected access modifiers for data members,
// and properties are used to control access to these members. For example, properties like NumberInput, CalculatorResult,
// OperatorInput, and RepeatCalculate encapsulate their respective data members and provide controlled access to them.

// Abstraction: Abstraction is achieved by hiding the internal implementation details of methods and data structures.
// The BaseCalculator class exposes only the necessary methods and properties for performing calculations and interacting
// with the calculator, hiding the complexity of the underlying operations.

// Inheritance: Inheritance is demonstrated by the GeneralCalculator class inheriting from the BaseCalculator class.
// This allows GeneralCalculator to inherit the properties and methods of BaseCalculator, promoting code reusability and
// establishing an "is-a" relationship between the two classes.

// Polymorphism: Polymorphism is implemented through method overriding in the GeneralCalculator class.
// Methods like Calculate, UserInput, PerformCalculation, DisplayList, and AskForRepeat are overridden with specific
// implementations in GeneralCalculator, allowing for different behaviors based on the context of GeneralCalculator
// while maintaining a common interface defined in BaseCalculator.
