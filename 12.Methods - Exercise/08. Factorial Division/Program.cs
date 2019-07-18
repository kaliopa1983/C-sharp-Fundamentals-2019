using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            double result = PrintDivision(number1, number2);
            Console.WriteLine($"{result:f2}");
        }

        private static double PrintDivision(int number1, int number2)
        {
           long a = CalculateFactorial1(number1);
           long b= CalculateFactorial2(number2);
            double result = (double)a / b;
            return result;
        }

        static long CalculateFactorial1(int number1)
        {
            long factoriel1 = 1;
            for (int i = 1; i <=number1; i++)
            {
                factoriel1 *= i;
            }
            return factoriel1;
        }
         static long CalculateFactorial2(int number2)
        {
            long factoriel2 = 1;
            for (int i = 1; i <= number2; i++)
            {
                factoriel2 *= i;
            }
            return factoriel2;
        }
    }
}
