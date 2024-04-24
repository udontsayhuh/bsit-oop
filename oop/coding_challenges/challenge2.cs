using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.coding_challenges
{
    internal class Challenge2
    {
        private string words;

        public void WordCount()
        {
            Console.Write("Enter a words/sentence: ");
            words = Console.ReadLine();
            string[] count = words.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(count.Length);

            Console.WriteLine(" ");
        }
    }
}
