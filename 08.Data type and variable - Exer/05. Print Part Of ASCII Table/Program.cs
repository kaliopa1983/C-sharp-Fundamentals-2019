using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startAsciiCode = int.Parse(Console.ReadLine());
            int lastAsciiCode = int.Parse(Console.ReadLine());
            
            for (int i = startAsciiCode; i <=lastAsciiCode; i++)
            {
               
                Console.Write((char)i+ " ");
            }
            //the char index you should start with and on the second line - the index of the last character 
        }
    }
}
