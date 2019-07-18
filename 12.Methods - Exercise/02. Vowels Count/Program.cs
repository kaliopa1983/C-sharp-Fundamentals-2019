using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int counter = 0;
            int result = CountVowels(word,counter);
            Console.WriteLine(result);
        }
        static int CountVowels(string word, int counter)
        {
            int result = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char currentSymbol = word[i];

                switch (currentSymbol)
                {
                    case 'a':
                        counter++;
                        break;
                    case 'e':
                        counter++;
                        break;
                    case 'u':
                        counter++;
                        break;
                    case 'i':
                        counter++;
                        break;
                    case 'o':
                        counter++;
                        break;
                    case 'y':
                        counter++;
                        break;
                    default:
                        break;
                }
                result= counter;


            }
            return result;
        }
    }
}
