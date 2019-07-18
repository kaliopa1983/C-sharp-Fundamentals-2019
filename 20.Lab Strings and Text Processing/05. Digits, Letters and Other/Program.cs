using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int digit = input[i];
                       Console.WriteLine(digit);
                }
               
                else if (char.IsLetter(input[i]))
                {
                    char letter = input[i];
                     Console.WriteLine(letter);
                }
               
               
                else if (!char.IsLetter(input[i])&&! char.IsDigit(input[i]))
                {
                    char symbol = input[i];
                    Console.WriteLine(symbol);
                }
             
               
               
            }
            
        }
    }
}
