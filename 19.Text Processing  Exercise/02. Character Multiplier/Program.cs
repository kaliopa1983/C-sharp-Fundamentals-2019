using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ");
            string firstString = strings[0];
            int totalSum = 0;
            string secondString = strings[1];
            string minStr = string.Empty;
            string maxStr = string.Empty;
            if (firstString.Length>secondString.Length)
            {
                 maxStr= firstString;
                  minStr=secondString;
            }
            else
            {
                  maxStr=secondString;
                  minStr=firstString;
            }
            for (int i = 0; i <minStr.Length; i++)
            {
                totalSum += minStr[i] * maxStr[i];
            }
            for (int i = minStr.Length; i < maxStr.Length; i++)
            {
                totalSum += maxStr[i];
            }
            Console.WriteLine(totalSum);

        }
    }
}
