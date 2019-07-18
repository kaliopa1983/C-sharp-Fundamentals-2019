using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string commands = String.Empty; 
            while (commands!="end")
            {
                commands = Console.ReadLine();
                string[] input = commands.Split(" ");

                if (input[0]== "Delete")
                 {
                       int elementToDelete =int.Parse( input[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                       if( numbers[i]==elementToDelete)
                        {
                            numbers.Remove(numbers[i]);
                               i-- ;
                        }
                    }       
                 }
                else if (input[0]=="Insert")
                {
                       int elementToInsert = int.Parse(input[1]);
                        int position = int.Parse(input[2]);
                        numbers.Insert(position, elementToInsert);
                }
                else if (commands == "end ")
                {
                    break;
                }

                
               
            }
                      Console.WriteLine(string.Join(" ", numbers));
             }
            
           
    }
}
