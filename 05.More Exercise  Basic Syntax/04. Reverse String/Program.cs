using System;
using System.Linq;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string words=Console.ReadLine();
            for (int i = words.Length-1; i>=0; i--)
            {
                
                  Console.Write(string.Join("",words[i]));
            }
            Console.WriteLine();
           
            
            

                
        }
    }
}
