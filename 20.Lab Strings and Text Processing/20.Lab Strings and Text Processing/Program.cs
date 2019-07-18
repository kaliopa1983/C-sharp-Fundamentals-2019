using System;

namespace _20.Lab_Strings_and_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            string reversed = string.Empty;
            while ((word=Console.ReadLine())!="end")
            {
                for (int i = word.Length; i >=0; i++)
                {
                    reversed +=(i);
                }
                
            }
            Console.WriteLine("{word} = {reversed}");
        }
    }
}
