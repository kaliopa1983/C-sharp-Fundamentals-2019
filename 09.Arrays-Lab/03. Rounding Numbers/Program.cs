using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundetNum = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                roundetNum[i] =(int) Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}",numbers[i],roundetNum[i]);
                
            }
            //0.9 => 1
        }
    }
}
