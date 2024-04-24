using System;
class ArithmeticFunctionsDisplay {
    public static void DisplayArithmeticFunctions() {
        Console.WriteLine(" =====================================================");
        Console.WriteLine("|                   SIMPLE CALCULATOR                 |");
        Console.WriteLine(" =====================================================");
        Console.WriteLine("|                          |                          |");
        Console.WriteLine("|            ( + )         |            ( - )         |");
        Console.WriteLine("|                          |                          |");
        Console.WriteLine("|            ( x )         |            ( / )         |");
        Console.WriteLine("|                          |                          |");
        Console.WriteLine(" =====================================================");
        Console.WriteLine();
    }
}
/*
    Single-Responsibility Principle was applied in the program by giving each class with only one responsibility.
    In addition, the interface below contains the method which is required to be implemented by the OperatorUserInput class.
This interface deploys the Open/Closed Principle because if there are necessary changes for the GetOperatorInput() method,
there is no need to modify this method inside the OperatorUserInput class, rather the programmer just need to add a new class
which will inherit this interface below and have a different implementation of the method inside of it which showcases
polymorphism as well. This way, this method is closed for modification but open for extension.
*/
interface IOperatorInputGetter {
    char GetOperatorInput();
}

class OperatorUserInput : IOperatorInputGetter {
    public char GetOperatorInput() {
        char op;
        // instead of using try-catch, if-else is used in error-handling to optimize the performance and speed of the program.
        while (true) {
            Console.Write("Enter the operator ('+', '-', '*', '\'): ");
            if (!char.TryParse(Console.ReadLine(), out op)) {
                Console.WriteLine("\nError: Invalid input. Please enter the valid operator...\n");
                continue;
            }
            else if (op != '+' && op != '-' && op != '*' && op != '/') {
                Console.WriteLine("\nError: Invalid input. Please enter the valid operator...\n");
                continue;
            }
            else {
                break;
            }
        }
        return op;
    }
}

/*
    A new interface was created below to deploy the Interface Segregation Principle. The method inside of the interface down below must
not be put inside the interface defined above because not all methods will be used by the inheriting class. The interface segregation
principle states that the clients like the classes OperatorUserInput and OperandsUserInput should not be forced to depend on methods they
do not use. Therefore in order to apply this in the program, these two classes have distinct interfaces so that they will only depend on
the method which they really need. 

    Not only that, because the Liskov Substitution Principle was also applied through this situation. Because an object of the interface
can be created through the instance of the class that inherits it which can be seen in the Main method down below.
*/

interface IOperandsInputGetter {
    double[] GetOperandsInput();
}

class OperandsUserInput : IOperandsInputGetter {
    public double[] GetOperandsInput() {
        double[] operands = new double[2];
        for (int i = 0; i < 2; i++) {
            while (true) {
                Console.Write("Enter a number: ");
                if (!double.TryParse(Console.ReadLine(), out operands[i])) {
                    Console.WriteLine("\nError: Invalid input. Please enter a valid number...\n");
                    continue;
                }  
                else {
                    break;
                }            
            }
        }
        return operands;
    }
}

/*
    The classes below inherits the interface ICalculation in order to have their own implementation for the method Calculate().
This situation deploys the Single-Responsibility Principle as each of the classes has only one responsibility.
It also deploys Open/Closed Principle because there is no need to modify the Calculate() method when necessary changes is added,
rather it was just extended through inheritance and polymorphism.
It also deploys Liskov Substitution Principle because an object of the interface can be created through the instances of each class
that inherits the interface which can be seen in the switch case in the Main method.
*/

public interface ICalculation {
    double Calculate(double[] operands);
}

class Addition : ICalculation {
    public double Calculate(double[] operands) {
        return operands[0] + operands[1];
    }
}

class Subtraction : ICalculation {
    public double Calculate(double[] operands) {
        return operands[0] - operands[1];
    }
}

class Multiplication : ICalculation {
    public double Calculate(double[] operands) {
        return operands[0] * operands[1];
    }
}

class Division : ICalculation {
    public double Calculate(double[] operands) {
        return operands[0] / operands[1];
    }
}

// This class validates the denominator inputted by the user which is the second operand
class OperandValidation {
    public static bool IsDenominatorValid(double denominator) {
        if (denominator == 0) {
            return false;
        }
        else {
            return true;
        }
    } 
}

class ResultDisplay {
    public static void DisplayResult(double result) {
        Console.WriteLine($"\nResult: {Math.Round(result, 2)}");
    }
}

class AnotherCalculation {
    public static bool IsGoingToCalculateAgain() {
        while(true) {
            try {
                Console.Write("Do you want to use calculator again? ('n' to exit): ");
                char ans;
                if (!char.TryParse(Console.ReadLine(), out ans)) {
                    throw new ArgumentException("\nError: Invalid input. Please enter any character...\n");
                }
                ans = char.ToLower(ans);
                if (ans == 'n') {
                    return false;
                }
                else {
                    return true;
                }
            }
            catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}

class SimpleCalculatorProgram {
    public static void Main(string[] args) {
        double result = 0;
        while (true) {
            Console.Clear();
            Console.WriteLine("Welcome to Simple Calculator!\n");
            ArithmeticFunctionsDisplay.DisplayArithmeticFunctions(); // Display the arithmetic functions
            IOperatorInputGetter operatorGetter = new OperatorUserInput();  // Application of LSP
            IOperandsInputGetter operandsGetter = new OperandsUserInput();  // Application of LSP

            // Get user inputs for operator and operands
            char op = operatorGetter.GetOperatorInput();
            double[] operands = operandsGetter.GetOperandsInput();

            // Perform switch case
            switch (op) {
                case '+':
                    ICalculation add = new Addition();              // LSP
                    result = add.Calculate(operands);
                    break;
                case '-':
                    ICalculation subtract = new Subtraction();      // LSP
                    result = subtract.Calculate(operands);
                    break;
                case '*':
                    ICalculation multiply = new Multiplication();   // LSP
                    result = multiply.Calculate(operands);
                    break;
                case '/':
                    ICalculation divide = new Division();           // LSP
                    // If the user input for denominator or second operand is valid, proceed to calculating the quotient
                    if (OperandValidation.IsDenominatorValid(operands[1])) {
                        result = divide.Calculate(operands);
                        break;
                    }
                    // But if the user input for denominator is 0 which is invalid, prompt user to input again until the input is valid
                    else {
                        while (true) {
                            Console.WriteLine("\nError: Invalid input. Please enter a non-zero number for denominator.");
                            Console.Write("Press Enter to input again...");
                            Console.ReadLine();
                            operands = operandsGetter.GetOperandsInput();
                            if (!OperandValidation.IsDenominatorValid(operands[1])) {
                                continue;
                            }
                            else {
                                result = divide.Calculate(operands);
                                break;
                            }
                        }
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid input. Please enter a valid operator...");
                    break;
            }       
            ResultDisplay.DisplayResult(result);
            bool calculateAgain =  AnotherCalculation.IsGoingToCalculateAgain();
            if (!calculateAgain) { // if not calculateAgain, then exit the program
                break;
            }
        }
    }
}
