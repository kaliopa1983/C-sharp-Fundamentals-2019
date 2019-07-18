using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            int newNumber = number;
            while (newNumber>0)
            {
              int lastDigit = newNumber % 10;
                sumDigits += lastDigit;
                newNumber = newNumber / 10;
            }
            Console.WriteLine(sumDigits);
            


        }
    }
}
