using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    abstract class StringChecking
    {
        public string Text { get; set; }

        protected StringChecking(string text)
        {
            Text = text;
        }

        public abstract int Checker();
        public abstract string upper();

    }

    class StringChecker : StringChecking
    {
        public StringChecker(string text) : base(text)
        {
            this.Text = text;
        }
        public override int Checker()
        {
            string[] words = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return words.Length;

        }
        public override string upper()
        {
            return Text.ToUpper();
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string text = Console.ReadLine();
            StringChecker checker = new StringChecker(text);
            int count = checker.Checker();
            Console.WriteLine("There are " + count + " word/s in the string");
            string UPPER = checker.upper();
            Console.WriteLine(UPPER);
        }
    }

}
