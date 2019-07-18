using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int countofTheWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            for (int i = 0; i <countofTheWords; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();
                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<string>());

                }
                words[word].Add(synonim);

            }
                foreach (var word in words)
                {
                    Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");


                }
            
        }
    }
}
