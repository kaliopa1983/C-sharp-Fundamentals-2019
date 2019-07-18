using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int times = 1; times <=10; times++)
            {
                int product = number * times;
                Console.WriteLine($"{number} X {times} = {product}");
            }
        }
    }
}
