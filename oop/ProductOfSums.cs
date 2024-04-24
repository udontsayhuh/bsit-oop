using System;

/*
    An interface is created below to contain the method that is required to be implemented by the class that
inherits that interface. This interface promotes the Open/Closed Principle because if ever there are necessary
changes in GetIntegerNumbers() method, there is no need to modify it inside the IntegerCollector class, but
rather the programmer just need to create a new class that will inherit the interface below and define a 
new implementation for the GetIntegerNumbers() method. Therefore, it is closed from modification and open for
extension through inheritance and polymorphism.
*/

interface IIntegerInputProvider {
    public int[] GetIntegerNumbers();
}

/* 
    The classes in the program like the one below follows the Single-Responsibility Principle because
the class has only one responsibility which is to get user input for integers. A new class was created for getting
user input for doubles. This way, each class has only one responsibility.
*/

class IntegerCollector : IIntegerInputProvider {
    public int[] GetIntegerNumbers() {
        int[] int_numbers = new int[2];
        for (int i = 0; i < 2; i++) {
            // Instead of using try-catch for exception-handling, if-else was used to optimize the performance and speed of the program
            while(true) {
                Console.Write($"Enter integer {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out int_numbers[i])) {
                    Console.WriteLine("\nFormat Error: Invalid input. Please enter an integer...\n");
                    continue;
                }
                break;
            }
        }
        return int_numbers;
    }
}

/*
    As you can see below, a new interface was created designed exclusively for the DoubleCollector class. The
interface above is exclusive for IntegerCollector. Why? This is to promote Liskov Substitution Principle and
Interface Segregation Principle. In terms of LSP, the instance of DoubleCollector class can implement an object
of the IDoubleInputProvider interface. And in terms of ISP, the interfaces for IntegerCollector and DoubleCollector
classes are segregated from each other because if they are combined, not all the methods in the interface will
be implemented by the specific inheriting class which violates ISP. So in order to adhere to it, interfaces were
segregated from each other in order to do not force clients like the class DoubleCollector in depending on methods
they do not use.
*/  

interface IDoubleInputProvider {
    public double[] GetDoubleNumbers();
}

class DoubleCollector : IDoubleInputProvider {
    public double[] GetDoubleNumbers() {
        double[] doub_numbers = new double[2];
        for (int i = 0; i < 2; i++) {
            while(true) {
                Console.Write($"Enter double {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out doub_numbers[i]) || double.IsInteger(doub_numbers[i])) {
                    Console.WriteLine("\nFormat Error: Invalid input. Please enter a double...\n");
                    continue;
                }
                break;
            }
         }
         return doub_numbers;
    }
}

// Methods below are declared as static to reduce memory usage rather than creating instances of their classes
class SumOfIntegers {
    public static int GetSumOfIntegers(int[] int_numbers) {
        int sumOfInt = 0;
        for (int i = 0; i < 2; i++) {
            sumOfInt += int_numbers[i];
        }
        return sumOfInt;
    }
}

class SumOfDoubles {
    public static double GetSumOfDoubles(double[] doub_numbers) {
        double sumOfDoubles = 0;
        for (int i = 0; i < 2; i++) {
            sumOfDoubles += doub_numbers[i];
        }
        return sumOfDoubles;
    }
}

class ProductOfSums {
    public static double GetProductOfSums(int sumOfInt, double sumOfDoubles) {
        return sumOfInt * sumOfDoubles;
    }
}

class ProductOfSumsProgram {
    public static void Main(string[] args) {
        Console.WriteLine("Welcome to Product of Sums Generator!\n");
        IIntegerInputProvider integerProvider = new IntegerCollector();  // This proves that LSP was applied in the program
        IDoubleInputProvider doubleProvider = new DoubleCollector();     // This proves that LSP was applied in the program

        // Get user input for integer and double numbers separately
        int[] int_numbers = integerProvider.GetIntegerNumbers();
        double[] doub_numbers = doubleProvider.GetDoubleNumbers();

        // Get the sum of integers and doubles separately
        int sumOfInt = SumOfIntegers.GetSumOfIntegers(int_numbers);
        double sumOfDoubles = SumOfDoubles.GetSumOfDoubles(doub_numbers);

        // Display the sums of integers and doubles
        Console.WriteLine($"\nSum of Integers: {sumOfInt}");
        Console.WriteLine($"Sum of Doubles: {sumOfDoubles}");

        // Get the product of the sums of integers and doubles and store in a double variable
        double productOfSums = ProductOfSums.GetProductOfSums(sumOfInt, sumOfDoubles);
        
        // Display the product of sums
        Console.WriteLine($"\nProduct of Sums: {productOfSums}"); 
    }
}
