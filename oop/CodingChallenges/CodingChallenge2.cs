using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace oop.CodingChallenges
{
    internal class CodingChallenge2
    {
        public void CountWord() 
        {
            Console.WriteLine("Word Counter");
            Console.Write("Enter a sentence or random words: ");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Total number of words: {words.Length}\n");
        }
    }
}
