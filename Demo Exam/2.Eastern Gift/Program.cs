using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Eastern_Gift
{
    class Program
    {
        static void Main()
        {
            List<string> gifts = Console.ReadLine()
                  .Split(" ")
                  .ToList();
                 string newWord = "None";
            while (true)
            {
                string message = Console.ReadLine();
                if (message== "No Money")
                {
                    break;
                }
                
                
                    string[] command = message.Split(" ");
                if (command[0] == "OutOfStock")
                {
                    string currentGift = command[1];
                    for (int i = 0; i < gifts.Count; i++)
                    {
                        if (gifts[i] == currentGift)
                       {
                            gifts.RemoveAt(i);
                            
                            gifts.Insert(i,newWord);
                       }
                    }
                    

                }
                else if (command[0] == "Required")
                {
                    string replaceGift = command[1];
                    int i = int.Parse(command[2]);
                    
                        if (i > 0 && i < gifts.Count)
                    { 
                       gifts.Remove(gifts[i]);

                        gifts.Insert(i, replaceGift);
                        
                   }

                    
                }
                else if (command[0] == "JustInCase")
                {
                    string replaceLastGift = command[1];
                    gifts.RemoveAt(gifts.Count-1);
                        
                    gifts.Add( replaceLastGift);

                }

            }
           
            if (gifts.Contains(newWord))
            {
                gifts.RemoveAll(n=> n== newWord);
                
            }
            Console.WriteLine(string.Join(" ",gifts));
        }
    }
}
