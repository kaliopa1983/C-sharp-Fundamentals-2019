using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int alfabetSum = 0;
            for (int i = 0; i < n; i++)
            {
                char alfabet = char.Parse(Console.ReadLine());
                alfabetSum += alfabet;

            }
            Console.WriteLine($"The sum equals: {alfabetSum}");
        }
    }
}
