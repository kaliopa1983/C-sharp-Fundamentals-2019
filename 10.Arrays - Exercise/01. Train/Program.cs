using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfwagons = int.Parse(Console.ReadLine());
            int[] numbers = new int[countOfwagons];

            for (int i = 0; i < countOfwagons; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
               
            }
            Console.WriteLine(string.Join(" ",numbers));
            Console.WriteLine(numbers.Sum());
        }
    }
}
