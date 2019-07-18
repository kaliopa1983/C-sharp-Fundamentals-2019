using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(number);

            Console.WriteLine(result);

        }

        private static int GetSumOfOddDigits(int number)
        {   int sumOfOdd = 0;

            while (number>0)
            {    
                int lastdigite = number % 10;
                if (lastdigite%2!=0)
                {
                    sumOfOdd+= lastdigite;

                }
                number = number / 10;
            }
            return sumOfOdd;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sumOfEven = 0;
            while (number>0)
            {
                int lastdigite = number % 10;
                if (lastdigite%2==0)
                {
                    sumOfEven += lastdigite;
                }
                number = number / 10;

            }
            return sumOfEven;
        }

        private static int GetMultipleOfEvenAndOdds(int number)
        {
          int a=  GetSumOfOddDigits( number);
           int b= GetSumOfEvenDigits( number);
            int result = a * b;
            return result;
        }
    }
}
