using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace codingChallenges
{
    using System;

    public class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }

        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        //function to add an item to the list
        public void Add(string data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        //function to print the list
        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        // Logic to sort the linked list using insertion sort
        public void Sort()
        {
            if (head == null || head.Next == null)
                return; // If list is empty or has only one node, it's already sorted

            Node sorted = null;
            Node current = head;

            while (current != null)
            {
                Node next = current.Next;
                sorted = Insert(sorted, current);
                current = next;
            }

            head = sorted; // Update head to point to the sorted list
        }

        // Logic to insert a node into the sorted part of the list
        private Node Insert(Node sorted, Node newNode)
        {
            if (sorted == null || string.Compare(newNode.Data, sorted.Data) < 0)
            {
                newNode.Next = sorted;
                return newNode;
            }
            else
            {
                Node current = sorted;
                while (current.Next != null && string.Compare(newNode.Data, current.Next.Data) > 0)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
                return sorted;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            //activity 1

            int num1, num2;
            double num3, num4;

            //input of 2 integers numbers
            
            Console.Write("Input first integer number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            //getting the sum of 2 integer numbers
            
            int sumOfIntegers = num1 + num2;
            
            //input of 2 double numbers
            
            Console.Write("Input first double number: ");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second double number: ");
            num4 = Convert.ToDouble(Console.ReadLine());
            
            //getting the sum of 2 double numbers
            
            double sumOfDouble = num3 + num4;
            Console.WriteLine($"The sum of integers {num1} and {num2} is {sumOfIntegers}");
            Console.WriteLine($"The sum of doubles {num3} and {num4} is {sumOfDouble}");
            //getting the product of the sum of double and integer
            double productOfTwo = sumOfIntegers + sumOfDouble;
            Console.WriteLine($"The product of the sums {sumOfDouble} and {sumOfIntegers} is {productOfTwo}");
            

            //activity 2


            string word;
            Console.Write("Enter a string: ");
            word = Console.ReadLine();            
            
            //counter logic for the counting of words
            
            int counter = 0;
            for(int i = 0; i < word.Length; i++)
            {
                
                if (word[i] == ' ')
                {
                    counter++;
                }
            }

            //inbuilt function to print the string in uppercase
            
            Console.WriteLine(word.ToUpper());

            Console.WriteLine($"The number of words in a string is {counter}");


            //activity 3


            while (true) {
                Console.Clear();
            int operation = 0;
            int choice = 0;
            int num1, num2;
            Console.WriteLine("[1] Addition\n[2] Subtraction\n[3] Multiplication\n[4] Division\n\n");
            Console.Write("[Menu]: ");
            operation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            //logic for the operations
            
            switch (operation)
                {
                    case 1:
                        Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"The difference of {num1} and {num2} is {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"The product of {num1} and {num2} is {Convert.ToDouble(num1 * num2)}");
                        break;
                    case 4:
                        if (num1 != 0 || num2 != 0)
                        {
                            Console.WriteLine($"The quotient of {num1} and {num2} is {Convert.ToDouble(num1 / num2)}");
                        }
                        else
                        {
                            Console.WriteLine("[Error] One of the numbers you have inserted is a 0");
                        }
                        break;

                }
                Console.Write("Would you like to try again? [1] Yes [2] No\n[Menu]: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 2) break;
            }
            

            //activity 4
            

            int num1, num2;
            Console.Write("Enter first integer number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //logic to get the multiplication table up to the given second number

            for(int i = 0; i < num2; i++)
            {
                Console.WriteLine($"{num1} x {i+1} = {num1 * i+1}");
            }
            */

            /*
             * Activity 5
             * The logic is in the above code before the program
            */

            LinkedList list = new LinkedList();
            list.Add("Toyota");
            list.Add("Honda");
            list.Add("Ford");
            list.Add("Volvo");
            list.Add("Audi");

            list.Sort();

            list.Print();
        }
    }
}