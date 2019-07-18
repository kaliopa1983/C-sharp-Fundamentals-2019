using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToList();
            List<int> secondList = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToList();
            List<int> resultList = new List<int>();
            for (int i = 0; i < Math.Min(firstList.Count,secondList.Count); i++)
            {
                int firstNumber = firstList[i];
                int secondNumber = secondList[i];
                resultList.Add(firstNumber);
                resultList.Add(secondNumber);
                 
            }
            if (firstList.Count>secondList.Count)
            {
                firstList.RemoveRange(0, secondList.Count);
                resultList.AddRange(firstList);
            }
            else if  (secondList.Count>firstList.Count)
            {
                secondList.RemoveRange(0, firstList.Count);
                resultList.AddRange(secondList);
            }
            Console.WriteLine(string.Join(" ",resultList));

        }
    }
}
