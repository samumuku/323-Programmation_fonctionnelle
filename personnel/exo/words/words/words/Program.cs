using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            words.Where(x => x.Length > words.Average(c => c.Length)).OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine($":ont autant de caractères que la moyenne du nombre de caractères de la liste: {x}"));

            words.Where(x => x != words.ElementAt(0) && x != words.ElementAt(words.Length - 1) && x != words.ElementAt(words.Length - 2)).ToList().ForEach(x => Console.WriteLine($"Données parasite 1 : {x}"));

            words.Skip(0).SkipLast();

            words.OrderBy(x => x).SkipWhile(x => !Regex.IsMatch(x, "{a-zA-Z}")).ToList().ForEach(x => Console.WriteLine($"Données parasite 2 : {x}"));
        }
    }
}
