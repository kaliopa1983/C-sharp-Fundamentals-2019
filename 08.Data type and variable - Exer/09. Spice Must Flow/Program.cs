using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int spicesMined = 0;
            int dropDownyieldConstant = 10;
            int workerConsume = 26;
            int days = 0;
            while (startingYield>100)
            {
                spicesMined += startingYield;
                spicesMined -= workerConsume;
                startingYield -= dropDownyieldConstant;
                days++;
            }
            spicesMined -= workerConsume;
            Console.WriteLine(days);
            Console.WriteLine(spicesMined); 
        }
    }
}
