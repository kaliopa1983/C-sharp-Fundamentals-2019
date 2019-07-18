using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
             PrintCharacters(firstSymbol, secondSymbol);
            
        }

        private static void PrintCharacters(char firstSymbol, char secondSymbol)
        {
            int startChar = Math.Min(firstSymbol, secondSymbol);
            int endChar = Math.Max(firstSymbol, secondSymbol);
            for (int i = startChar+1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
          
            
        }
    }
}
