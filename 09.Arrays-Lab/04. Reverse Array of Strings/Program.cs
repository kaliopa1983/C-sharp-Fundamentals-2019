﻿using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            
            for (int i = 0; i <arr.Length/2; i++)
            {
                string oldElement = arr[i];
                arr[i] = arr[arr.Length- i - 1];
                arr[arr.Length - i - 1] = oldElement;
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
