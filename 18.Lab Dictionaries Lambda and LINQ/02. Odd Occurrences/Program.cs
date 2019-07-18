using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();
            Dictionary<string, int> occurance= new Dictionary<string, int>();
            foreach  (string word in words)
            {
                string wordToLowerCase = word.ToLower();
                if (occurance.ContainsKey(wordToLowerCase))
                {
                    occurance[wordToLowerCase]++;

                }
                else
                {
                    occurance.Add(wordToLowerCase, 1);
                }

            }
            foreach(var item in occurance)
            {
                if (item.Value %2 !=0)
                {
                    Console.Write( item.Key + " ");
                }
            }

        }
    }
}
