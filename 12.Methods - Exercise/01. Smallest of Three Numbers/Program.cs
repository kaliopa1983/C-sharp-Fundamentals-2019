using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
           int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = GetMinInteger( firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        private static int GetMinInteger(int a,int b,int c)
        { int result = 0;
            if (a <= b && a<=c)
            {
                result = a;
            }
            else if (b<=a && b<= c)
            {
                result = b;
            }
            else if (c<=a && c<=b)
            {
                result= c;
            }
            return result;
        }
    }
}
