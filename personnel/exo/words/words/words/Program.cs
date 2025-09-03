using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

            // Partie 1.1
            Action<string> letterXWords = word =>
            {
                if (word.Contains("x"))
                {
                    Console.WriteLine("Partie 1.1: " + word);
                }
            };
            foreach (string word in words)
            {
                letterXWords(word);
            }

            // Partie 1.2
            const int NUMBER_FOUR = 4;
            Action<string> overFourLetterWord = word =>
            {
                if (word.Length > NUMBER_FOUR)
                {
                    Console.WriteLine("Partie 1.2: " + word);
                }
            };
            foreach (string word in words)
            {
                overFourLetterWord(word);
            }

            // Partie 1.3
            Action<double> calcAverage = i => words[i]
            Action<string> equalToAvg = word => 
        }
    }
}
