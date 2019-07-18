using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                 .Split()
                 .ToArray();
            for (int i =text.Length-1; i >=0; i--)
            {
                Console.WriteLine(text[i]);
            }



        }
    }
}
