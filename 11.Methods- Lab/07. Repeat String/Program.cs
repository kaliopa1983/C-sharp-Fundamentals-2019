using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(inputString, count);
            Console.WriteLine(result);

        }

         static string RepeatString(string inputString, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                 result += inputString;
                
           
            }
            return result;
        }
    }
}
