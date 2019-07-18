using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int copyNumber = number;
            int sum = 0;
            
            while (copyNumber != 0)
            {
                int currentDigit = copyNumber % 10;
                int currentFactorial = 1;
                for (int i = 1; i <= currentDigit; i++)
                {
                    currentFactorial *= i;
                }
                sum += currentFactorial;
                copyNumber /= 10;
            }
           
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

