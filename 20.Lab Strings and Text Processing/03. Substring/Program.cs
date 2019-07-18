using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var result = Console.ReadLine();
          
           int index = result.IndexOf(word);
            while (index!=-1)
            {
              result = result.Remove(index,word.Length);
                index = result.IndexOf(word);
            }

         
            Console.WriteLine(result);

            

        }
    }
}
