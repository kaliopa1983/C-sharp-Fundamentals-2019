using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                int number = int.Parse(Console.ReadLine());
                if (number%2!=0)
                {
                    Console.WriteLine("Please write an even number.");
                    i++;
                }
                else
                {
                    Console.WriteLine("The number is: {0}",Math.Abs(number));
                    break;
                }
            } while (i<=10);
        }
    }
}


