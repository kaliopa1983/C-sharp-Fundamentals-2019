using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int number = numbers[0];
            int maxCount = 1;
            int currentCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                int previousNumber = numbers[i - 1];
                int currentNumbers = numbers[i];
                if (previousNumber==currentNumbers)
                {
                    currentCount++;
                    if (currentCount>maxCount)
                    {
                        maxCount = currentCount;
                        number = currentNumbers;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
