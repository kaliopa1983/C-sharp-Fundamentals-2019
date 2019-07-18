using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sorted = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();
            if (sorted.Length>=3)
            {
                  for (int i = 0; i <3; i++)
                  {
                    Console.Write(sorted[i]+ " " );
                  }
            }
            else
            {
                for (int i = 0; i < sorted.Length; i++)
                {
                    Console.Write(sorted[i] + " ");
                }
            }
            
        }
    }
}
