using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 1; number <= n; number++)
            {
                int sumOfdigits = 0;
                int digits = number;
                while (digits > 0)
                {
                    sumOfdigits += digits % 10;
                    digits = digits / 10;
                }
                bool Isnumspec = false;
                if ((sumOfdigits == 5) || (sumOfdigits == 7) || (sumOfdigits == 11))
                {
                    Isnumspec = true;
                    
                }
                else
                {
                    Isnumspec = false;
                }
                Console.WriteLine($"{number} -> {Isnumspec}");


            }
        }
    }
}
