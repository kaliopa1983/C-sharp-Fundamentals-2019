using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
           List< string> input = Console.ReadLine()
               . Split()
               .ToList();


            List<char> stringArr = input.ToList();
          
                
          
            
            int occurrence = 0;
                 
                 Dictionary<char, int> countChars = new Dictionary<char, int>();
           
            foreach(var c in stringArr)
            {
                if (countChars.ContainsKey(c))
                {  occurrence++;
                    countChars[c] = occurrence + 1; ;
                  
                  
                }

                else
                {
                    countChars[c] = 1;

                }
              
            }
            
            foreach (KeyValuePair<char,int> item in countChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
           
            

        }
    }
}
