using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double paunds = double.Parse(Console.ReadLine());
            double dollars = 1.31 * paunds;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
