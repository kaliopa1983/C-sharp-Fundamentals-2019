using System;

namespace _04._Print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                sum += i;
                Console.Write("{0} ", i);
                

            }
            Console.Write("\n");
            Console.WriteLine($"Sum: {sum}");
            

        }
    }
}
