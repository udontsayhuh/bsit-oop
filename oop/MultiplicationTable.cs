using System;

/*
    The interface below contains a method which is required to be implemented by the class that will inherit this 
interface. Putting the method inside an interface promotes Open/Closed principle because if a certain class would 
have a different implementation of the GetMultiplicand() method, that class just have to inherit the interface below, 
instead of modifying the GetMultiplicand() directly in the class where it was implemented.  
*/
interface IMultiplicandCollector {
    public int GetMultiplicand();
}

/*
    The class below has only one responsibility inside of it to promote Single-Responsibility principle which states
that a class must only have one responsibility. The sole responsibility of the class below is to get user input for
multiplicand. 
*/

class ConsoleMultiplicandCollector : IMultiplicandCollector {
    public int GetMultiplicand() {
        int multiplicand;
        while (true) {
            Console.Write("Enter an integer for multiplicand: ");
            if (!int.TryParse(Console.ReadLine(), out multiplicand)) {
                Console.WriteLine("\nFormat Error: Invalid input. Please enter an integer...\n");
                continue;
            }
            break;
        }
        return multiplicand;
    }
}

/*
    As you can see below, another interface was created which contains the GetMultiplier() method. I have the choice to
store this method as well in the interface above which is the IMultiplicandCollector then just change its name to IInputCollector,
but I did not in order to promote Single Responsibility Principle, Open/Closed Principle and Interface Segregation Principle.
SRP and OCP was explained above, but with regards to ISP, the interfaces must be segregated properly. If I put GetMultiplicand()
and GetMultiplier() methods inside one interface named IInputCollector, then the inheriting class named ConsoleMultiplicandCollector
only used "one" method from the interface, then it violates the ISP and as well as the Liskov Substitution principle. ISP is then 
applied by segregating the interface into two instead of just one. Therefore, all the method defined in each interface was used by
inheriting classes which achieves the principle of LSP which states that all the methods inherited by derived class from base class
must be implemented in the base class properly. 
*/

interface IMultiplierCollector {
    public int GetMultiplier();
}

class ConsoleMultiplierCollector : IMultiplierCollector {
    public int GetMultiplier() {
        int multiplier;
        while (true) {
            Console.Write("Enter an integer for multiplier: ");
            if (!int.TryParse(Console.ReadLine(), out multiplier)) {
                Console.WriteLine("\nFormat Error: Invalid input. Please enter an integer...\n");
                continue;
            }
            break;
        }
        return multiplier;
    }
}

interface ITableGenerator {
    public void DisplayMultiplicationTable();
}

class MultiplicationTableGenerator : ITableGenerator {
    // Properties of Multiplication 
    // They follow PascalNamingConvention because they are properties
    // They are specifically auto-implemented properties, meaning the compiler generates backing field for them
    public int Multiplicand { get; set; }
    public int Multiplier { get; set; }

    // Constructor method to pass the values in properties of the class
    public MultiplicationTableGenerator(int multiplicand, int multiplier) {
        this.Multiplicand = multiplicand;
        this.Multiplier = multiplier;
    }

    public void DisplayMultiplicationTable() {
        Console.WriteLine("\nMultiplication Table: ");
        for (int i = 1; i <= Multiplier; i++) {
            Console.WriteLine($"- {Multiplicand} * {i} = {Multiplicand * i}");
        }
    }
}

class MultiplicationTableProgram {
    public static void Main(string[] args) {
        Console.WriteLine("Welcome to Multiplication Table Generator!\n");
        IMultiplicandCollector multiplicandCollector = new ConsoleMultiplicandCollector();
        IMultiplierCollector multiplierCollector = new ConsoleMultiplierCollector();

        // Get user input for multiplicand and multiplier
        int multiplicand = multiplicandCollector.GetMultiplicand();
        int multiplier = multiplierCollector.GetMultiplier();

        // Generate a multiplication table
        ITableGenerator multiplicationTableGenerator = new MultiplicationTableGenerator(multiplicand, multiplier);

        // Display the multiplication table
        multiplicationTableGenerator.DisplayMultiplicationTable();
    }
}
