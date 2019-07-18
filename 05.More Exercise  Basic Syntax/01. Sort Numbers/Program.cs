using System;
using System.Collections.Generic;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i <3; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            list.Sort();
            list.Reverse();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
