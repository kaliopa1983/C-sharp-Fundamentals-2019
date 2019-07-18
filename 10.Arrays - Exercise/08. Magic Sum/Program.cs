using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            
            int givenNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumber = numbers[i];
                for (int j = i+1; j <numbers.Length; j++)
                {
                    int secondNumber = numbers[j];
                    if (firstNumber+secondNumber==givenNumber)
                    {
                        Console.WriteLine(firstNumber + " " + secondNumber);
                    }
                }
            }
            
        }
    }
}
