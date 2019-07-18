using System;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            text.Distinct().Select(c => c.ToString()).ToList()
    .ForEach(c =>
    {
        while (text.Contains(c + c))
            text = text.Replace(c + c, c);
    }
        );
            Console.WriteLine(string.Join("",text));
        }
    }
}

