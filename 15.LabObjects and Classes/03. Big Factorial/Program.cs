﻿using System;
using System.Numerics;
namespace _03._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            
            for (int i = 2; i <= number; i++)
            {
                 factorial = i * factorial;
            }
            Console.WriteLine(factorial);
        }
    }
}
