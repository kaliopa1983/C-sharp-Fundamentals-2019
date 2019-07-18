using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    int evenNum = numbers[i];
                    evenSum += evenNum;
                }
                else
                {
                    int oddNum = numbers[i];
                    oddSum += oddNum;

                }
            }
            Console.WriteLine(evenSum-oddSum);
        }
    }
}
