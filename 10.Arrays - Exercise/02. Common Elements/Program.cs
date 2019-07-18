using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(" ")
                .ToArray();
            string[] secondArr = Console.ReadLine()
                 .Split(" ")
                 .ToArray();
            for (int i = 0; i < secondArr.Length; i++)
            {
                string element = secondArr[i];

                for (int j = 0; j < firstArr.Length; j++)
                {
                    string currentElement = firstArr[j];

                    if (element==currentElement)
                    {
                        Console.Write(element + " ");
                    }
                }
            }
        }
    }
}
