using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintMatrix( number);
        }

        private static void PrintMatrix( int number)
        {
            for (int row = 1; row <=number; row++)
            {
                Console.Write(number);
                for (int col = 1; col <number ;col ++)
                {
                    Console.Write(" "+ number);
                }
                Console.WriteLine();
            }
        }
    }
}
