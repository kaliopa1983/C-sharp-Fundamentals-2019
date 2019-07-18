using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rigthSum = numbers.Sum();

            for (int i = 0; i < numbers.Length; i++)
            {
                rigthSum -= numbers[i];
                if (leftSum==rigthSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSum += numbers[i];
               
            }
            Console.WriteLine("no");

        }
    }
}
