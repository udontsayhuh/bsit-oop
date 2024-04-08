// This is the second version of the Calculator program
// If the user input is invalid, the program will ask the user to input again
// This version of calculator is not limited to two operands

﻿using System;
using System.Collections.Generic;
using System.Threading;

// Implementation of abstraction
// For me, putting all the methods in an abstract class help me identify the methods used inside the program
public abstract class Operations {
    public abstract void DisplayOperations();
    public abstract void Calculate(List<double> numbers, List<char> operators);   
    public abstract void DisplayResult();
    public abstract void ClearLists(List<double> numbers, List<char> operators);
    public abstract void Loading();
    public abstract void ClearConsole();
    public abstract void ThankYou();
}

public class Calculator : Operations {
    // Lists declared as private to encapsulate them within the Calculator class
    // They are not directly accessible within other classes
    private List<double> numbers = new List<double>();  // Create a list for numbers
    private List<char> operators = new List<char>();    // Create a list for operators
    public double result; // this variable stores the final result of the Calculator
    // Property to expose the 'numbers' list using getter
    public List<double> GetNumbers {
        get { return numbers; }
    }
    // Property to expose the 'operators' list using getter
    public List<char> GetOperators {
        get { return operators; }
    }

    // Method to display the operations
    public override void DisplayOperations() {
            Console.WriteLine(" =====================================================");
            Console.WriteLine("|                     CALCULATOR                      |");
            Console.WriteLine(" =====================================================");
            Console.WriteLine("|                          |                          |");
            Console.WriteLine("|            ( + )         |            ( - )         |");
            Console.WriteLine("|                          |                          |");
            Console.WriteLine("|            ( x )         |            ( / )         |");
            Console.WriteLine("|                          |                          |");
            Console.WriteLine(" =====================================================");
            Console.WriteLine();
    }

    // Method to get user input for the 'numbers' and 'operators' list
    public void GetUserInput() {
        double num;     // stores the number w/c will be added to the 'numbers' list
        char op = '+';  // stores the operator w/c will be added to the 'operators' list

        // Continue getting user input until the operator is equals to this sybmol '='
        while(op != '=') {
            // User input for 'numbers' list
            // Continue getting user input for number until the inputted number is valid
            while(true) {
                try {
                    Console.Write("Enter a number: ");
                    if(!double.TryParse(Console.ReadLine(), out num)) {
                        // Throw ArgumentException if user input for number is invalid
                        throw new ArgumentException("Invalid input. Please enter a valid number.");
                    }
                    // Store the number to the 'numbers' list if the user input is valid
                    numbers.Add(num);
                    // Exit the loop if the user input for number is valid
                    break;
                }
                catch(ArgumentException e) {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                } 
            }

            // User input for 'operators' list
            // Continue getting user input for operator until the inputted operator is valid
            while(true) {
                try {
                    Console.Write("Enter the operator: ");
                    if (!char.TryParse(Console.ReadLine(), out op)) {
                        // Throw ArgumentException if user input for operator is invalid
                        throw new ArgumentException("Invalid input. Please enter a valid operator.");
                    }
                    // If user input is '=', store it to operators list then terminate the loop
                    if (op == '=') {
                        operators.Add(op);
                        break;
                    }
                    // Another set of conditions to check if the user input for operator is valid or not
                    if (op != '+' && op != '-' && op != '*' && op != '/') {
                        // Throw ArgumentException if user input for operator is invalid
                        throw new ArgumentException("Invalid input. Please enter a valid operator.");
                    }
                    // Store the operator to the 'operators' list if the user input is valid
                    operators.Add(op);
                    // Exit the loop if the user input is valid
                    break;
                }
                catch(ArgumentException e) {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
            }
        } 
    }

    // Method for calculations
    public override void Calculate(List<double> numbers, List<char> operators) {
        // Computation process
        // Below are the increment variables used as indices to access the elements of the list
        // i serves as the index used to access the elements in the 'numbers' list
        // j servers as the index used to access the elements in the 'operators' list
        // limit is used to determine how many numbers are going to be solved
        int i, j, k;
        i = j = 0;     // all initialized as zero to access the first element of the lists
        int limit; 
        // result stores the final value
        result = 0;
        // size_of_list stores the size or length of the 'operators' list
        int size_of_list = operators.Count;

        // This while loop below is the main algorithm that functions as the calculator
        // It will stop solving the moment it encounters the last operator which is the '=' operator
        while(j < size_of_list) {
            // k is an increment variable that determines how many number will be solved between an operator
            k = 0;
            // j == 0 only means that during the first operator, there are maximum of two numbers that will be solved
            // that is why limit is equals to 2
            if (j == 0) {
                limit = 2;
            }
            // But on succeeding operators, the maximum number involved is only one
            // that is why limit is equals to 1
            else {
                limit = 1;
            }
            
            // switch case
            switch(operators[j]) {
                case '+':
                    while(k < limit) {
                        result = result + numbers[i];
                        i++; // increment i to access the next number in the 'numbers' list
                        k++; // increment k to know if there is still another number that needs to be added in the result
                    }
                    break;
                case '-':
                    // j == 0 pertains to the first operator in the 'operators' list
                    // If the loop is currently in the first operator, the value of the result variable
                    // should be the value of the first number in the list
                    // Note: this only applies to subtraction, multiplication and division
                    if (j == 0) {
                        result = numbers[i];
                        k = 1;
                        i++;
                    }
                    while(k < limit) {
                        result = result - numbers[i];
                        i++; // increment i to access the next number in the 'numbers' list
                        k++; // increment k to know if there is still another number that needs to be added in the result
                    }
                    break;
                case '*':
                    if (j == 0) {
                        result = numbers[i];
                        k = 1;
                        i++;
                    }
                    while(k < limit) {
                        result = result * numbers[i];
                        i++; // increment i to access the next number in the 'numbers' list
                        k++; // increment k to know if there is still another number that needs to be added in the result
                    }
                    break;
                case '/':
                    if (j == 0) {
                        result = numbers[i];
                        k = 1;
                        i++;
                    }
                    while(k < limit) {
                        result = result / numbers[i];
                        i++; // increment i to access the next number in the 'numbers' list
                        k++; // increment k to know if there is still another number that needs to be added in the result
                    }
                    break;
                case '=':
                    result = result;
                    break;
                default:
                    throw new ArgumentException("Invalid input.");
            }
            j++;
        }
    }

    // Method to display final output
    public override void DisplayResult() {
        int i, j;
        i = j = 0;
        ClearConsole();
        DisplayOperations();

        // Display the result this way if there are two or more operands / numbers
        if (numbers.Count > 1) {
            Console.WriteLine(" =====================================================");
            Console.Write(" EQUATION: ");
            while (i < numbers.Count) {
                Console.Write(numbers[i] + " " + operators[j] + " ");
                i++;
                j++;
            }
            Console.Write(result);
            Console.WriteLine("\n RESULT: " + result);
            Console.WriteLine(" =====================================================");
            Console.WriteLine("\n");
        }
        

        // Display the result this way if there is only operand / number
        else {
            Console.WriteLine(" =====================================================");
            Console.WriteLine(" RESULT: " + numbers[0]);
            Console.WriteLine(" =====================================================");
        }
    }

    // Method to clear the lists
    public override void ClearLists(List<double> numbers, List<char> operators) {
        numbers.Clear();
        operators.Clear();
    }

    // Method to clear console
    public override void ClearConsole() {
        Console.SetCursorPosition(0, 0);
        Console.Write(new string(' ', Console.WindowWidth * Console.WindowHeight));
        Console.SetCursorPosition(0, 0);
    }

    // Method for threading
    public override void Loading() {
        Thread.Sleep(1000);
        for(int i = 0; i < 3; i++) {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
    }

    // Method to display thank you phrase for using the system
    public override void ThankYou() {
        Console.WriteLine(" ===============================================");
        Console.WriteLine("|                                               |");
        Console.WriteLine("|                   THANK YOU                   |");
        Console.WriteLine("|             FOR USING THE PROGRAM!            |");
        Console.WriteLine("|                                               |");
        Console.WriteLine(" ===============================================");
    }
}

public class CalculatorApp {
    static void Main(string[] args) {
        while(true) {
            Calculator calculator = new Calculator();
            calculator.DisplayOperations();
            calculator.GetUserInput();
            List<double> numbers = calculator.GetNumbers;
            List<char> operators = calculator.GetOperators;
            calculator.Calculate(numbers, operators);
            
            // Display result
            Console.Write("\nLoading ");
            calculator.Loading();
            calculator.DisplayResult();

            // Ask the user for another calculation
            Console.Write(" Do you want to calculate again? (y / n): ");
            char ans = char.ToLower(Convert.ToChar(Console.ReadLine()));
            if (ans == 'n') {
                Console.Write("\n Exiting program ");
                calculator.Loading();
                calculator.ClearConsole();
                calculator.ThankYou();
                break;
            }

            // Clear the lists
            Console.Write("\n Clearing lists ");
            calculator.Loading();
            calculator.ClearLists(numbers, operators);

            // Clear the console
            calculator.ClearConsole();
        }     
    }
}