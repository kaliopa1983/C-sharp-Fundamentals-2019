using System;
using System.Numerics;

namespace _11___Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger value = 0;

            BigInteger max = 0;

            for (int i = 1; i <= n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                value = BigInteger.Pow((snow / time), quality);

                if (value > max)
                {
                    max = value;
                    snowballSnow = snow;
                    snowballTime = time;
                    snowballQuality = quality;
                }

            }

            Console.WriteLine($"{snowballSnow} : {snowballTime} = {max} ({snowballQuality})");
        }
    }
}