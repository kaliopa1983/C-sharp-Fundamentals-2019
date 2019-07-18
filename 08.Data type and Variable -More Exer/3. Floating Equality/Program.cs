using System;

namespace _3._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double difference = Math.Abs(a) - Math.Abs(b);
           double eps = 0.000001;
            if (difference<eps)
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False");
            }
        }
    }
}
