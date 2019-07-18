using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopNumber( n);
        }

        private static void PrintTopNumber(int n)
        {
            
            for (int i = 1; i <= n; i++)

            {
                int sumOfDigit = 0;

                bool IsOddDigit = false;
                int number = i;
                while (true)
                {
                  if(number==0)
                    {
                        break;
                    }
                   int lastdigit = number % 10;
                    sumOfDigit += lastdigit;
                  if (lastdigit%2!=0)
                  {
                    IsOddDigit = true;
                  }
                   number = number / 10;
                }

               if (sumOfDigit%8==0 && IsOddDigit==true)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}

