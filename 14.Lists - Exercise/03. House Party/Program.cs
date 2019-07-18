using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
           int numberOfcommands =int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i <numberOfcommands;i++)
            {
                string firstInput = Console.ReadLine();
                
     
                string[] firstMessege = firstInput.Split();

                
                if (firstMessege.Length==3)
                {
                    string nameToAdd = firstMessege[0];
                    if (names.Contains(nameToAdd))
                    {
                        Console.WriteLine($"{nameToAdd} is already in the list!");
                    }
                    else
                    {
                        names.Add(nameToAdd);
                    }
                }
                else if (firstMessege.Length==4)
                {
                    string nameToRemove = firstMessege[0];
                    if (names.Contains(nameToRemove))
                    {
                        names.Remove(nameToRemove);
                    }
                    else
                    {
                        Console.WriteLine($"{nameToRemove} is not in the list!");
                    }
                }

               
            } 
            for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine(names[i]); 
                }
            Console.WriteLine();
        }
    }
}
