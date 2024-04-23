using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }
    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}


class Program
{
    static void Main(string[] args)
    {
        menu();
    }
    static void menu()
    {
        Console.Clear();
        int temp;
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("|                    C# CODING CHALLENGES                    |");
        Console.WriteLine("--------------------------------------------------------------");
        Console.Write("| Please select coding challenge number (1 to 5) 6 to exit: ");
        while (!int.TryParse(Console.ReadLine(), out temp) ||
            (temp != 1 && temp != 2 && temp != 3 && temp != 4 && temp != 5 && temp != 6))
        {
            Console.WriteLine("| Invalid input please try again");
            Console.Write("| Please select coding challenge number (1 to 5) 6 to exit: ");
        }
        switch (temp)
        {
            case 1:
                challenge1();
                break;
            case 2:
                challenge2();
                break;
            case 3:
                challenge3();
                break;
            case 4:
                challenge4();
                break;
            case 5:
                challenge5();
                break;
            case 6:
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("|                         THANK YOU                          |");
                Console.WriteLine("--------------------------------------------------------------");
                break;


        }
    }
    static void challenge1()
    {
        Console.Clear();
        Console.WriteLine("|\n| CHALLENGE NO# 1\n| ");
        Console.WriteLine("|\n| Interger input\n| ");
        int num1 = user_int();
        int num2 = user_int();
        Console.WriteLine("|\n| Double input\n|");
        double num3 = user_double();
        double num4 = user_double();
        int int_sum = sum(num1, num2);
        double double_sum = sum(num3, num4);
        Console.WriteLine($"|\n| The sum of the two integers is: {int_sum}");
        Console.WriteLine($"| The sum of the two doubles is: {double_sum}");
        double sum_product = product(int_sum, double_sum);
        Console.WriteLine($"| The product of the two sums is: {sum_product}\n|\n|");
        Console.WriteLine("| Press any key to return in menu");
        Console.ReadKey();
        menu();
    }
    static void challenge2()
    {
        Console.Clear();
        Console.WriteLine("|\n| CHALLENGE NO# 2\n| ");
        string string_input = user_input();
        int length = word_counter(string_input);
        Console.WriteLine($"| The input has {length} words\n|\n|");
        Console.WriteLine("|Press any key to return in menu");
        Console.ReadKey();
        menu();
    }
    static void challenge3()
    {
        Console.Clear();
        Console.WriteLine("|\n| CHALLENGE NO# 3\n| ");
        char operand = user_operand();
        double num1 = user_double();
        double num2 = user_double();
        double result = 0;
        switch (operand)
        {
            case '+':
                result = sum(num1, num2);
                break;
            case '-':
                result = difference(num1, num2);
                break;
            case '*':
                result = product(num1, num2);
                break;
            case '/':
                result = qoutient(num1, num2);
                break;
            default:
                break;
        }
        Console.WriteLine($"| The result is: {result}");
        challenge3_retry();
    }
    static void challenge4()
    {
        Console.Clear();
        Console.WriteLine("|\n| CHALLENGE NO# 4\n| ");
        double num1 = user_double();
        double num2 = user_double();
        for (double i = 1; i <= num2; i++)
        {
            Console.WriteLine($"{num1} x {i} = {num1 * i}");
        }
        Console.WriteLine("|\n|\n| Press any key to return in menu");
        Console.ReadKey();
        menu();
    }
    static void challenge5()
    {
        Console.Clear();
        Console.WriteLine("|\n| CHALLENGE NO# 5\n| ");
        Node<string> node1 = new Node<string>("Toyota");
        Node<string> node2 = new Node<string>("CyberCar");
        Node<string> node3 = new Node<string>("Bugatti");
        Node<string> node4 = new Node<string>("Lamborgini");
        Node<string> node5 = new Node<string>("Ferrari");
        node1.Next = node2;
        node2.Next = node3;
        node3.Next = node4;
        node4.Next = node5;
        Node<string> curr = node1;
        Console.WriteLine("| ORIGINAL NODE ORDER\n| ");
        while (curr != null)
        {
            Console.WriteLine("| " + curr.Data);
            curr = curr.Next;
        }
        ProcessNode(ref node1);
        Console.WriteLine("|\n|\n| Press any key to return in menu");
        Console.ReadKey();
        menu();
    }
    public static void ProcessNode<T>(ref Node<T> node)
    {
        Node<T> head = node;
        Node<T> curr = node;
        Node<T> temp;

        while (curr != null)
        {
            while (curr.Next != null)
            {
                if (Comparer<T>.Default.Compare(curr.Data, curr.Next.Data) > 0)
                {
                    temp = curr.Next;
                    curr.Next = temp.Next;
                    temp.Next = curr;

                    if (curr == head)
                    {
                        head = temp;
                    }
                    else
                    {
                        Node<T> prev = head;
                        while (prev.Next != curr)
                        {
                            prev = prev.Next;
                        }
                        prev.Next = temp;
                    }
                    curr = head;
                }
                else
                {
                    curr = curr.Next;
                }
            }
            curr = curr.Next;
        }
        node = head;
        curr = node;
        Console.WriteLine("|\n| SORTED NODE ORDER\n| ");
        while (curr != null)
        {
            Console.WriteLine("| " + curr.Data);
            curr = curr.Next;
        }
    }
    static void challenge3_retry()
    {
        char temp;
        Console.Write("| Would you like to compute again? 'Y'(yes) 'N'(no): ");
        while (!char.TryParse(Console.ReadLine(), out temp) ||
            (temp != 'y' && temp != 'Y' && temp != 'n' && temp != 'N'))
        {
            Console.WriteLine("| Invalid input please try again");
            Console.Write("| Would you like to try again? 'Y'(yes) 'N'(no): ");
        }
        if (temp == 'Y' || temp == 'y')
        {
            challenge3();
        }
        else
        {
            Console.WriteLine("| Press any key to return in menu");
            Console.ReadKey();
            menu();
        }
    }
    static string user_input()
    {

        Console.Write("| Enter a string: ");
        string temp = Console.ReadLine();
        if (temp != string.Empty)
        {
            return temp;
        }
        else
        {
            Console.WriteLine("| String cannot be empty please try again");
            return user_input();
        }
    }
    static int word_counter(string words)
    {
        string[] saved = words.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return saved.Length;
    }

    static int user_int()
    {
        int temp;
        Console.Write("| Enter an integer: ");
        while (!int.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("| Invalid input please try agian");
            Console.Write("| Enter an integer: ");
        }
        return temp;
    }
    static char user_operand()
    {
        char temp;
        Console.Write("| Enter an operand ('+', '-', '*', '/': ");
        while (!char.TryParse(Console.ReadLine(), out temp) ||
                (temp != '+' && temp != '-' && temp != '*' && temp != '/'))
        {
            Console.WriteLine("| Invalid operand please try agian");
            Console.Write("| Enter an integer: ");
        }
        return temp;
    }
    static double user_double()
    {
        double temp;
        Console.Write("| Enter a number: ");
        while (!double.TryParse(Console.ReadLine(), out temp))
        {
            Console.WriteLine("| Invalid input please try agian");
            Console.Write("| Enter an double: ");
        }
        return temp;
    }
    static int sum(int num1, int num2)
    {
        return (num1 + num2);
    }
    static double sum(double num1, double num2)
    {
        return (num1 + num2);
    }
    static double difference(double num1, double num2)
    {
        return (num1 - num2);
    }
    static double product(double num1, double num2)
    {
        return (num1 * num2);
    }
    static double qoutient(double num1, double num2)
    {
        return (num1 / num2);
    }
    static double product(int num1, double num2)
    {
        return ((double)num1 * num2);
    }
}